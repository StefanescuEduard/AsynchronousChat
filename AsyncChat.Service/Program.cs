using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;

namespace AsyncChat.Service
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 
		internal static void Main(string[] args)
		{
			var chatServer = ChatService.GetInstance();

			if (args[0] == "--console" || args[0] == "-c")
			{
				if (string.IsNullOrEmpty(args[1]))
				{
					Console.Write("You need to provide an IP address: ");
					args[1] = Console.ReadLine();
					Main(args);
				}

				chatServer.AsyncServer.SetConnectionToHost(Dns.GetHostEntry(args[1])
						.AddressList.First(address => address.AddressFamily == AddressFamily.InterNetwork));
				chatServer.RunAsConsole(args);
			}
			else
			{
				try
				{
					ServiceBase[] ServicesToRun;

					EventLog.WriteEntry("AsyncServerService", Dns.GetHostEntry(Dns.GetHostName())
						.AddressList.First(address => address.AddressFamily == AddressFamily.InterNetwork).ToString(), EventLogEntryType.Information);

					chatServer.AsyncServer.SetConnectionToHost(Dns.GetHostEntry(Dns.GetHostName())
						.AddressList.First(address => address.AddressFamily == AddressFamily.InterNetwork));
					ServicesToRun = new ServiceBase[]
					{
						chatServer
					};
					ServiceBase.Run(ServicesToRun);
				}
				catch (Exception ex)
				{
					EventLog.WriteEntry("AsyncServerService", ex.ToString(), EventLogEntryType.Error);
				}
			}
		}
	}
}
