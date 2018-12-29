using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AsyncChat.Domain
{
	public class AsyncClient
	{
		private readonly State state;
		private readonly IPAddress ipAddress;
		public delegate void ChatContentReceived();
		public ChatContentReceived ChatContentReceivedMethod;

		public string ChatContent { get; private set; }

		public AsyncClient(string clientAddress)
		{
			state = new State
			{
				Port = 23571,
				BufferSize = 256
			};
			ipAddress = Dns.GetHostEntry(clientAddress).AddressList
				.First(address => address.AddressFamily == AddressFamily.InterNetwork);
			state.EndPoint = new IPEndPoint(ipAddress, state.Port);
			state.Buffer = new byte[state.BufferSize];
		}

		public void Connect()
		{
			try
			{
				state.TcpListener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

				state.TcpListener.BeginConnect(state.EndPoint, new AsyncCallback(ConnectCallback), null);
			}
			catch (Exception)
			{
				// TODO: Log exception to file and throw it
			}
		}

		public void Send(string message)
		{
			try
			{
				var bytesToSend = Encoding.ASCII.GetBytes(message);

				state.TcpListener.BeginSend(bytesToSend, 0, bytesToSend.Length, SocketFlags.None,
					new AsyncCallback(SendCallback), null);
			}
			catch (Exception)
			{
				// TODO: Log exception to file and throw it
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
			catch (Exception)
			{
				// TODO: Log exception to file and throw it
			}
		}

		private void SendCallback(IAsyncResult asyncResult)
		{
			try
			{
				state.TcpListener.EndSend(asyncResult);
			}
			catch (Exception)
			{
				// TODO: Log exception to file and throw it
			}
		}

		private void ReceiveCallback(IAsyncResult asyncResult)
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
	}
}
