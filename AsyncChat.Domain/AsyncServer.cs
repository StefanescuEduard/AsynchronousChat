using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AsyncChat.Domain
{
	public class AsyncServer
	{
		private readonly State state;
		private IPAddress ipAddress;
		private readonly List<Socket> clients;

		public AsyncServer()
		{
			clients = new List<Socket>();
			state = new State
			{
				Port = 23571,
				BufferSize = 1024
			};
			ipAddress = Dns.GetHostEntry(Dns.GetHostName())
				.AddressList.First(address => address.AddressFamily == AddressFamily.InterNetwork);
			state.EndPoint = new IPEndPoint(ipAddress, state.Port);
			state.Buffer = new byte[state.BufferSize];
		}

		public void StartListening()
		{
			state.TcpListener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

			state.TcpListener.Bind(state.EndPoint);
			state.TcpListener.Listen(50);

			state.TcpListener.BeginAccept(new AsyncCallback(AcceptCallback), null);
		}

		public void StopListening()
		{
			if (state.TcpListener != null)
			{
				state.TcpListener.Shutdown(SocketShutdown.Both);
				state.TcpListener.Close();
				state.TcpListener = null;
			}
		}

		private void AcceptCallback(IAsyncResult asyncResult)
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
			clientSocket.BeginReceive(state.Buffer, 0, state.BufferSize, SocketFlags.None,
				new AsyncCallback(ReceiveCallback), clientSocket);
		}

		private void ReceiveCallback(IAsyncResult asyncResult)
		{
			var clientSocket = (Socket)asyncResult.AsyncState;

			int bytesToRead = clientSocket.EndReceive(asyncResult);

			if (bytesToRead > 0)
			{
				var content = Encoding.ASCII.GetString(state.Buffer, 0, bytesToRead);

				if (content == "disconnect")
				{
					clients.Remove(clientSocket);
					DisconnectCurrentClient(clientSocket);
					return;
				}

				NotifyClients(content);
				clientSocket.BeginReceive(state.Buffer, 0, state.BufferSize, SocketFlags.None,
					new AsyncCallback(ReceiveCallback), clientSocket);
			}
		}

		private void DisconnectCurrentClient(Socket clientSocket)
		{
			clientSocket.Shutdown(SocketShutdown.Both);
			clientSocket.Close();
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
			var bytesToSend = Encoding.ASCII.GetBytes(content);

			client.BeginSend(bytesToSend, 0, bytesToSend.Length, SocketFlags.None, new AsyncCallback(SendCallback), client);
		}

		private void SendCallback(IAsyncResult asyncResult)
		{
			var client = (Socket)asyncResult.AsyncState;

			int bytesSent = client.EndSend(asyncResult);
		}
	}
}
