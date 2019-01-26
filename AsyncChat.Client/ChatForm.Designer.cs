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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
			this.panBackground = new System.Windows.Forms.Panel();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.rTxtContent = new System.Windows.Forms.RichTextBox();
			this.lblServer = new System.Windows.Forms.Label();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblConnectionStatus = new System.Windows.Forms.Label();
			this.picBoxStatus = new System.Windows.Forms.PictureBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnSend = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnLogOut = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnConnect = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnDisconnect = new MaterialSkin.Controls.MaterialRaisedButton();
			((System.ComponentModel.ISupportInitialize)(this.picBoxStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// panBackground
			// 
			this.panBackground.Location = new System.Drawing.Point(0, 64);
			this.panBackground.Name = "panBackground";
			this.panBackground.Size = new System.Drawing.Size(604, 292);
			this.panBackground.TabIndex = 17;
			// 
			// txtIP
			// 
			this.txtIP.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtIP.Location = new System.Drawing.Point(72, 102);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(240, 26);
			this.txtIP.TabIndex = 25;
			// 
			// rTxtContent
			// 
			this.rTxtContent.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.rTxtContent.Location = new System.Drawing.Point(14, 133);
			this.rTxtContent.Name = "rTxtContent";
			this.rTxtContent.ReadOnly = true;
			this.rTxtContent.Size = new System.Drawing.Size(580, 182);
			this.rTxtContent.TabIndex = 18;
			this.rTxtContent.Text = "";
			// 
			// lblServer
			// 
			this.lblServer.AutoSize = true;
			this.lblServer.BackColor = System.Drawing.Color.Transparent;
			this.lblServer.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblServer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblServer.Location = new System.Drawing.Point(11, 106);
			this.lblServer.Name = "lblServer";
			this.lblServer.Size = new System.Drawing.Size(54, 18);
			this.lblServer.TabIndex = 24;
			this.lblServer.Text = "Server:";
			// 
			// txtMessage
			// 
			this.txtMessage.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtMessage.Location = new System.Drawing.Point(14, 321);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(471, 30);
			this.txtMessage.TabIndex = 19;
			this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnChatContentBoxKeyDown);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.BackColor = System.Drawing.Color.Transparent;
			this.lblStatus.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblStatus.Location = new System.Drawing.Point(11, 77);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(55, 18);
			this.lblStatus.TabIndex = 21;
			this.lblStatus.Text = "Status:";
			// 
			// lblConnectionStatus
			// 
			this.lblConnectionStatus.AutoSize = true;
			this.lblConnectionStatus.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConnectionStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(52)))));
			this.lblConnectionStatus.Location = new System.Drawing.Point(99, 78);
			this.lblConnectionStatus.Name = "lblConnectionStatus";
			this.lblConnectionStatus.Size = new System.Drawing.Size(94, 17);
			this.lblConnectionStatus.TabIndex = 23;
			this.lblConnectionStatus.Text = "disconnected";
			// 
			// picBoxStatus
			// 
			this.picBoxStatus.BackColor = System.Drawing.Color.Transparent;
			this.picBoxStatus.Image = ((System.Drawing.Image)(resources.GetObject("picBoxStatus.Image")));
			this.picBoxStatus.Location = new System.Drawing.Point(72, 73);
			this.picBoxStatus.Name = "picBoxStatus";
			this.picBoxStatus.Size = new System.Drawing.Size(24, 24);
			this.picBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBoxStatus.TabIndex = 22;
			this.picBoxStatus.TabStop = false;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btnSend
			// 
			this.btnSend.Depth = 0;
			this.btnSend.Location = new System.Drawing.Point(492, 322);
			this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnSend.Name = "btnSend";
			this.btnSend.Primary = true;
			this.btnSend.Size = new System.Drawing.Size(103, 28);
			this.btnSend.TabIndex = 33;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.OnSendButtonClick);
			// 
			// btnLogOut
			// 
			this.btnLogOut.Depth = 0;
			this.btnLogOut.Location = new System.Drawing.Point(506, 100);
			this.btnLogOut.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Primary = true;
			this.btnLogOut.Size = new System.Drawing.Size(87, 28);
			this.btnLogOut.TabIndex = 32;
			this.btnLogOut.Text = "Log out";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.OnLogoutButtonClick);
			// 
			// btnConnect
			// 
			this.btnConnect.Depth = 0;
			this.btnConnect.Location = new System.Drawing.Point(317, 100);
			this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Primary = true;
			this.btnConnect.Size = new System.Drawing.Size(75, 28);
			this.btnConnect.TabIndex = 30;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.OnConnectButtonClick);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Depth = 0;
			this.btnDisconnect.Location = new System.Drawing.Point(398, 100);
			this.btnDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Primary = true;
			this.btnDisconnect.Size = new System.Drawing.Size(102, 28);
			this.btnDisconnect.TabIndex = 31;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.OnDisconnectButtonClick);
			// 
			// ChatForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 356);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.rTxtContent);
			this.Controls.Add(this.lblServer);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lblConnectionStatus);
			this.Controls.Add(this.picBoxStatus);
			this.Controls.Add(this.panBackground);
			this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ChatForm";
			this.Text = "Chattie";
			((System.ComponentModel.ISupportInitialize)(this.picBoxStatus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panBackground;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.RichTextBox rTxtContent;
		private System.Windows.Forms.Label lblServer;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblConnectionStatus;
		private System.Windows.Forms.PictureBox picBoxStatus;
		private System.Windows.Forms.ImageList imageList1;
		private MaterialSkin.Controls.MaterialRaisedButton btnSend;
		private MaterialSkin.Controls.MaterialRaisedButton btnLogOut;
		private MaterialSkin.Controls.MaterialRaisedButton btnConnect;
		private MaterialSkin.Controls.MaterialRaisedButton btnDisconnect;
	}
}

