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

		public delegate void ChatContentReceived();
		public ChatContentReceived ChatContentReceivedMethod;

		public delegate void ExceptionThrown(string exceptionMessage);
		public ExceptionThrown ExceptionThrownMethod;

		public string ChatContent { get; private set; }

		public AsyncClient()
		{
			logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		}

		public void SetConnectionForClient(string clientAddress)
		{
			try
			{
				state = new State
				{
					Port = 23571,
					BufferSize = 256
				};
				ipAddress = ipAddress = Dns.GetHostEntry(clientAddress).AddressList
												.First(address => address.AddressFamily == AddressFamily.InterNetwork);
				state.EndPoint = new IPEndPoint(ipAddress, state.Port);
				state.Buffer = new byte[state.BufferSize];
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message, exception);
				ExceptionThrownMethod.Invoke(exception.Message);
			}
		}

		public bool Connect()
		{
			try
			{
				state.TcpListener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

				state.TcpListener.BeginConnect(state.EndPoint, new AsyncCallback(ConnectCallback), null);

				return true;
			}
			catch (Exception exception)
			{
				logger.Error(exception.Message, exception);
				ExceptionThrownMethod.Invoke(exception.Message);
			}

			return false;
		}

		public void Send(string message)
		{
			try
			{
				var bytesToSend = Encoding.ASCII.GetBytes(message);

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
					ChatContent = Encoding.ASCII.GetString(state.Buffer, 0, bytesToRead);
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
	}
}
