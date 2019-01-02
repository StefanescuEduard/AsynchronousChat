using AsyncChat.Presentation.Views;

namespace AsyncChat.Presentation
{
	partial class ChatForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
			this.rTxtContent = new System.Windows.Forms.RichTextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.picBoxStatus = new System.Windows.Forms.PictureBox();
			this.lblConnectionStatus = new System.Windows.Forms.Label();
			this.btnLogout = new System.Windows.Forms.Button();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.lblServer = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.panBackground = new System.Windows.Forms.Panel();
			this.loginView = new AsyncChat.Presentation.Views.LoginView();
			((System.ComponentModel.ISupportInitialize)(this.picBoxStatus)).BeginInit();
			this.panBackground.SuspendLayout();
			this.SuspendLayout();
			// 
			// rTxtContent
			// 
			this.rTxtContent.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.rTxtContent.Location = new System.Drawing.Point(12, 64);
			this.rTxtContent.Name = "rTxtContent";
			this.rTxtContent.ReadOnly = true;
			this.rTxtContent.Size = new System.Drawing.Size(580, 182);
			this.rTxtContent.TabIndex = 6;
			this.rTxtContent.Text = "";
			this.rTxtContent.TextChanged += new System.EventHandler(this.OnChatContentTextChanged);
			// 
			// txtMessage
			// 
			this.txtMessage.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtMessage.Location = new System.Drawing.Point(12, 252);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(471, 30);
			this.txtMessage.TabIndex = 7;
			this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnChatContentBoxKeyDown);
			// 
			// btnSend
			// 
			this.btnSend.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.btnSend.Location = new System.Drawing.Point(489, 252);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(102, 30);
			this.btnSend.TabIndex = 8;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.OnSendButtonClick);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.Location = new System.Drawing.Point(9, 9);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(55, 18);
			this.lblStatus.TabIndex = 9;
			this.lblStatus.Text = "Status:";
			// 
			// picBoxStatus
			// 
			this.picBoxStatus.BackColor = System.Drawing.Color.Transparent;
			this.picBoxStatus.Image = global::AsyncChat.Presentation.Properties.Resources.PowerCordRed;
			this.picBoxStatus.Location = new System.Drawing.Point(70, 4);
			this.picBoxStatus.Name = "picBoxStatus";
			this.picBoxStatus.Size = new System.Drawing.Size(24, 24);
			this.picBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBoxStatus.TabIndex = 10;
			this.picBoxStatus.TabStop = false;
			// 
			// lblConnectionStatus
			// 
			this.lblConnectionStatus.AutoSize = true;
			this.lblConnectionStatus.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConnectionStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(52)))));
			this.lblConnectionStatus.Location = new System.Drawing.Point(97, 9);
			this.lblConnectionStatus.Name = "lblConnectionStatus";
			this.lblConnectionStatus.Size = new System.Drawing.Size(94, 17);
			this.lblConnectionStatus.TabIndex = 11;
			this.lblConnectionStatus.Text = "disconnected";
			// 
			// btnLogout
			// 
			this.btnLogout.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.btnLogout.Location = new System.Drawing.Point(505, 31);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(86, 30);
			this.btnLogout.TabIndex = 16;
			this.btnLogout.Text = "Log out";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.OnLogoutButtonClick);
			// 
			// txtIP
			// 
			this.txtIP.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtIP.Location = new System.Drawing.Point(70, 34);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(148, 26);
			this.txtIP.TabIndex = 13;
			// 
			// lblServer
			// 
			this.lblServer.AutoSize = true;
			this.lblServer.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblServer.Location = new System.Drawing.Point(9, 38);
			this.lblServer.Name = "lblServer";
			this.lblServer.Size = new System.Drawing.Size(54, 18);
			this.lblServer.TabIndex = 12;
			this.lblServer.Text = "Server:";
			// 
			// btnConnect
			// 
			this.btnConnect.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.btnConnect.Location = new System.Drawing.Point(316, 31);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 30);
			this.btnConnect.TabIndex = 14;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.OnConnectButtonClick);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.btnDisconnect.Location = new System.Drawing.Point(397, 31);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(102, 30);
			this.btnDisconnect.TabIndex = 15;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.OnDisconnectButtonClick);
			// 
			// panBackground
			// 
			this.panBackground.Controls.Add(this.loginView);
			this.panBackground.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panBackground.Location = new System.Drawing.Point(0, 0);
			this.panBackground.Name = "panBackground";
			this.panBackground.Size = new System.Drawing.Size(604, 292);
			this.panBackground.TabIndex = 17;
			// 
			// loginView
			// 
			this.loginView.Location = new System.Drawing.Point(158, 3);
			this.loginView.Margin = new System.Windows.Forms.Padding(50, 3, 15, 3);
			this.loginView.Name = "loginView";
			this.loginView.Size = new System.Drawing.Size(298, 298);
			this.loginView.TabIndex = 0;
			this.loginView.Visible = false;
			// 
			// ChatForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 292);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.lblServer);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.lblConnectionStatus);
			this.Controls.Add(this.picBoxStatus);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.rTxtContent);
			this.Controls.Add(this.panBackground);
			this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ChatForm";
			this.Text = "Chattie";
			((System.ComponentModel.ISupportInitialize)(this.picBoxStatus)).EndInit();
			this.panBackground.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RichTextBox rTxtContent;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.PictureBox picBoxStatus;
		private System.Windows.Forms.Label lblConnectionStatus;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label lblServer;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Panel panBackground;
		private LoginView loginView;
	}
}

