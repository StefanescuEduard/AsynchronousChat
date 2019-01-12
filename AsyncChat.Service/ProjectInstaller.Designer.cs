namespace AsyncChat.Service
{
	partial class ProjectInstaller
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.asyncChatServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
			this.asyncChatServiceInstaller = new System.ServiceProcess.ServiceInstaller();
			// 
			// asyncChatServiceProcessInstaller
			// 
			this.asyncChatServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
			this.asyncChatServiceProcessInstaller.Password = null;
			this.asyncChatServiceProcessInstaller.Username = null;
			// 
			// asyncChatServiceInstaller
			// 
			this.asyncChatServiceInstaller.Description = "Open an internal server that manage a chat server";
			this.asyncChatServiceInstaller.ServiceName = "TestService12";
			// 
			// ProjectInstaller
			// 
			this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.asyncChatServiceProcessInstaller,
            this.asyncChatServiceInstaller});

		}

		#endregion

		private System.ServiceProcess.ServiceProcessInstaller asyncChatServiceProcessInstaller;
		private System.ServiceProcess.ServiceInstaller asyncChatServiceInstaller;
	}
}