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
			if (args[0] == "console")
			{
				var chatServer = ChatService.GetInstance();
				chatServer.RunAsConsole(args);
			}
			else
			{
				ServiceBase[] ServicesToRun;
				ServicesToRun = new ServiceBase[]
				{
					ChatService.GetInstance()
				};
				ServiceBase.Run(ServicesToRun);
			}
		}
	}
}
