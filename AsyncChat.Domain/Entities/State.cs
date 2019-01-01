using System.Net;
using System.Net.Sockets;

namespace AsyncChat.Domain.Entities
{
	public class State
	{
		public Socket TcpListener { get; set; }
		public Socket Handler { get; set; }
		public IPEndPoint EndPoint { get; set; }
		public int Port { get; set; }
		public int BufferSize { get; set; }
		public byte[] Buffer { get; set; }
	}
}
