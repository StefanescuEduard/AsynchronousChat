using AsyncChat.Domain.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace AsyncChat.Domain
{
	public class AsyncServer
	{
		private readonly State state;
		private IPAddress ipAddress;
		private readonly List<Socket> clients;
		private readonly ILog logger;
		private readonly MessageCryptor messageCryptor;

		private const int Port = 23571;

		public AsyncServer()
		{
			logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
			clients = new List<Socket>();
			state = new State
			{
				BufferSize = 1024
			};
			state.Buffer = new byte[state.BufferSize];
			messageCryptor = new MessageCryptor();
		}

		public void SetConnectionToHost(IPAddress ipAddress)
		{
			this.ipAddress = ipAddress;
			state.EndPoint = new IPEndPoint(ipAddress, Port);
		}

		public void StartListening()
		{
			try
			{
				state.TcpListener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

				state.TcpListener.Bind(state.EndPoint);
				state.TcpListener.Listen(50);

				state.TcpListener.BeginAccept(new AsyncCallback(AcceptCallback), null);
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message, exception);
			}
		}

		public void StopListening()
		{
			try
			{
				if (state.TcpListener != null)
				{
					DisconnectAllClients();
					state.TcpListener.Shutdown(SocketShutdown.Both);
					state.TcpListener.Close();
					state.TcpListener = null;
				}
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message);
			}
		}

		private void AcceptCallback(IAsyncResult asyncResult)
		{
			try
			{
				state.Handler = state.TcpListener.EndAccept(asyncResult);
				var clientSocket = state.Handler;
				if (!clients.Contains(clientSocket))
				{
					clients.Add(clientSocket);
				}
				else
				{
					clientSocket = clients.Find(socket => socket == state.Handler);
				}
				ClientConnectedMethod?.Invoke();
				clientSocket.BeginReceive(state.Buffer, 0, state.BufferSize, SocketFlags.None,
					new AsyncCallback(ReceiveCallback), clientSocket);
				state.TcpListener.BeginAccept(new AsyncCallback(AcceptCallback), null);
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message);
			}
		}

		private void ReceiveCallback(IAsyncResult asyncResult)
		{
			try
			{
				var clientSocket = (Socket)asyncResult.AsyncState;

				int bytesToRead = clientSocket.EndReceive(asyncResult);

				if (bytesToRead > 0)
				{
					var content = Encoding.Unicode.GetString(state.Buffer, 0, bytesToRead);

					if (content == "disconnect")
					{
						clients.Remove(clientSocket);
						DisconnectCurrentClient(clientSocket);
						ClientDisconnectedMethod.Invoke();
						return;
					}

					NotifyClients(content);
					clientSocket.BeginReceive(state.Buffer, 0, state.BufferSize, SocketFlags.None,
						new AsyncCallback(ReceiveCallback), clientSocket);
				}
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message);
			}
		}

		private void DisconnectCurrentClient(Socket clientSocket)
		{
			try
			{
				clients.Remove(clientSocket);
				clientSocket.Shutdown(SocketShutdown.Both);
				clientSocket.Close();
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message);
			}
		}

		private void DisconnectAllClients()
		{
			foreach (var client in clients)
			{
				DisconnectCurrentClient(client);
			}
		}

		private void NotifyClients(string content)
		{
			foreach (var client in clients)
			{
				Send(client, content);
			}
		}

		private void Send(Socket client, string content)
		{
			try
			{
				var bytesToSendDecrypter = messageCryptor.DecryptMessage(Encoding.Unicode.GetBytes(content));

				client.BeginSend(bytesToSendDecrypter, 0, bytesToSendDecrypter.Length, SocketFlags.None, new AsyncCallback(SendCallback), client);
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message);
			}
		}

		private void SendCallback(IAsyncResult asyncResult)
		{
			try
			{
				var client = (Socket)asyncResult.AsyncState;

				int bytesSent = client.EndSend(asyncResult);
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message);
			}
		}

		public delegate void ClientConnected();
		public ClientConnected ClientConnectedMethod;

		public delegate void ClientDisconnected();
		public ClientConnected ClientDisconnectedMethod;
	}
}
