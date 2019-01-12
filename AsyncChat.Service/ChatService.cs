using AsyncChat.Domain;
using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;

namespace AsyncChat.Service
{
	public partial class ChatService : ServiceBase
	{
		private static ChatService chatService;
		private static readonly object syncObject = new object();
		private Thread serverThread;

		public AsyncServer AsyncServer { get; private set; }

		public ChatService()
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
				Thread.Sleep(10000);
				serverThread = new Thread(() => AsyncServer.StartListening());
				serverThread.Start();
			}
			catch (Exception exception)
			{
				EventLog.WriteEntry("AsyncServerService", exception.ToString(), EventLogEntryType.Error);
			}
		}

		protected override void OnStop()
		{
			try
			{
				serverThread.Abort();
				serverThread = new Thread(() => AsyncServer.StopListening());
				serverThread.Start();
			}
			catch (Exception exception)
			{
				EventLog.WriteEntry("AsyncServerService", exception.ToString(), EventLogEntryType.Error);
			}
		}

		public void RunAsConsole(string[] args)
		{
			Console.WriteLine("Server started.");
			AsyncServer.ClientConnectedMethod += DisplayConnectedMessage;
			AsyncServer.ClientDisconnectedMethod += DisplayDisconnectedMessage;
			Console.WriteLine("Press CTRL+C to close the AsyncChat service.");
			OnStart(args);
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
			Console.WriteLine("Client disconnected.");
		}
	}
}
