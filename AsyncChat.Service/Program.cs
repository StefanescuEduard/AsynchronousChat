using System;
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
			if (string.IsNullOrEmpty(args[1]))
			{
				Console.Write("You need to provide an IP address: ");
				args[1] = Console.ReadLine();
			}
			if (args[0] == "console")
			{
				chatServer.AsyncServer.SetConnectionToHost(Dns.GetHostEntry(args[1])
						.AddressList.First(address => address.AddressFamily == AddressFamily.InterNetwork), Convert.ToInt32(args[2]));
				chatServer.RunAsConsole(args);
			}
			else
			{
				ServiceBase[] ServicesToRun;
				chatServer.AsyncServer.SetConnectionToHost(Dns.GetHostEntry(Dns.GetHostName())
					.AddressList.First(address => address.AddressFamily == AddressFamily.InterNetwork), 23571);
				ServicesToRun = new ServiceBase[]
				{
					chatServer
				};
				ServiceBase.Run(ServicesToRun);
			}
		}
	}
}
