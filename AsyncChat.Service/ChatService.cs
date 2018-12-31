using AsyncChat.Domain;
using System;
using System.ServiceProcess;

namespace AsyncChat.Service
{
	public partial class ChatService : ServiceBase
	{
		private static ChatService chatService;
		private static readonly object syncObject = new object();

		public AsyncServer AsyncServer { get; private set; }

		private ChatService()
		{
			InitializeComponent();

			AsyncServer = new AsyncServer();
		}

		public static ChatService GetInstance()
		{
			lock (syncObject)
			{
				if (chatService == null)
				{
					chatService = new ChatService();
				}
			}

			return chatService;
		}

		protected override void OnStart(string[] args)
		{
			try
			{
				AsyncServer.StartListening();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
			}
		}

		protected override void OnStop()
		{
			try
			{
				AsyncServer.StopListening();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
			}
		}

		public void RunAsConsole(string[] args)
		{
			Console.WriteLine("Server started.");
			AsyncServer.ClientConnectedMethod += DisplayConnectedMessage;
			AsyncServer.ClientDisconnectedMethod += DisplayDisconnectedMessage;
			OnStart(args);
			Console.WriteLine("Press CTRL+C to close the AsyncChat service.");
			Console.ReadKey();
			OnStop();
			Console.WriteLine("Server stopped.");
			Console.ReadKey();
		}

		public void DisplayConnectedMessage()
		{
			Console.WriteLine("Client connected.");
		}

		public void DisplayDisconnectedMessage()
		{
			Console.WriteLine("Client connected.");
		}
	}
}
