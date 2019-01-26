using AsyncChat.Domain.Entities;
using log4net;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace AsyncChat.Domain
{
	public class AsyncClient
	{
		private State state;
		private IPAddress ipAddress;
		private readonly ILog logger;
		private readonly MessageCryptor messageCryptor;

		private const int Port = 23571;

		public string ChatContent { get; private set; }

		public AsyncClient()
		{
			logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
			messageCryptor = new MessageCryptor();
		}

		public void SetConnectionForClient(string clientAddress)
		{
			try
			{
				state = new State
				{
					BufferSize = 1024
				};

				if (clientAddress == "localhost")
				{
					ipAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList
													.First(address => address.AddressFamily == AddressFamily.InterNetwork);
				}
				else
				{
					ipAddress = Dns.GetHostEntry(clientAddress).AddressList
													.First(address => address.AddressFamily == AddressFamily.InterNetwork);
				}

				state.EndPoint = new IPEndPoint(ipAddress, Port);
				state.Buffer = new byte[state.BufferSize];
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message, exception);
				ExceptionThrownMethod.Invoke(exception.Message);
			}
		}

		public void Connect()
		{
			try
			{
				state.TcpListener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

				state.TcpListener.BeginConnect(state.EndPoint, new AsyncCallback(ConnectCallback), null);

				ConnectionInvokedMethod.Invoke(true);
			}
			catch (Exception exception)
			{
				ConnectionInvokedMethod.Invoke(false);
				logger.Error(exception.Message, exception);
				ExceptionThrownMethod.Invoke(exception.Message);
			}
		}

		public void Send(string message)
		{
			try
			{
				//var bytesToSend = messageCryptor.EncryptMessage(Encoding.Unicode.GetBytes(message));
				var bytesToSend = Encoding.Unicode.GetBytes(message);

				state.TcpListener.BeginSend(bytesToSend, 0, bytesToSend.Length, SocketFlags.None,
					new AsyncCallback(SendCallback), null);
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message, exception);
				ExceptionThrownMethod.Invoke(exception.Message);
			}
		}

		private void ConnectCallback(IAsyncResult asyncResult)
		{
			try
			{
				state.TcpListener.EndConnect(asyncResult);

				state.TcpListener.BeginReceive(state.Buffer, 0, state.BufferSize, SocketFlags.None,
					new AsyncCallback(ReceiveCallback), null);
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message, exception);
				ExceptionThrownMethod.Invoke(exception.Message);
			}
		}

		private void SendCallback(IAsyncResult asyncResult)
		{
			try
			{
				state.TcpListener.EndSend(asyncResult);
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message, exception);
				ExceptionThrownMethod.Invoke(exception.Message);
			}
		}

		private void ReceiveCallback(IAsyncResult asyncResult)
		{
			try
			{
				var bytesToRead = state.TcpListener.EndReceive(asyncResult);

				if (bytesToRead > 0)
				{
					ChatContent = Encoding.Unicode.GetString(state.Buffer, 0, bytesToRead);
					ChatContentReceivedMethod.Invoke();

					state.TcpListener.BeginReceive(state.Buffer, 0, state.BufferSize, SocketFlags.None,
							new AsyncCallback(ReceiveCallback), null);
				}
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message, exception);
				ExceptionThrownMethod.Invoke(exception.Message);
			}
		}

		public delegate void ChatContentReceived();
		public ChatContentReceived ChatContentReceivedMethod;

		public delegate void ExceptionThrown(string exceptionMessage);
		public ExceptionThrown ExceptionThrownMethod;

		public delegate void ConnectionInvoked(bool connected);
		public ConnectionInvoked ConnectionInvokedMethod;
	}
}
