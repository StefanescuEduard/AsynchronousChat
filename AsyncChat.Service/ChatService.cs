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
				Console.WriteLine("Server started.");
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
				Console.WriteLine("Server stopped.");
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
			}
		}

		public void RunAsConsole(string[] args)
		{
			OnStart(args);
			Console.WriteLine("Press any key to close the AsyncChat service.");
			Console.ReadKey();
			OnStop();
		}
	}
}
