namespace AsyncChat.Client
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
			this.lblIP = new System.Windows.Forms.Label();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.rTxtContent = new System.Windows.Forms.RichTextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.lblStatus = new System.Windows.Forms.Label();
			this.picBoxStatus = new System.Windows.Forms.PictureBox();
			this.lblConnectionStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picBoxStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// lblIP
			// 
			this.lblIP.AutoSize = true;
			this.lblIP.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblIP.Location = new System.Drawing.Point(12, 34);
			this.lblIP.Name = "lblIP";
			this.lblIP.Size = new System.Drawing.Size(25, 18);
			this.lblIP.TabIndex = 0;
			this.lblIP.Text = "IP:";
			// 
			// txtIP
			// 
			this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtIP.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtIP.Location = new System.Drawing.Point(43, 34);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(148, 19);
			this.txtIP.TabIndex = 1;
			// 
			// btnConnect
			// 
			this.btnConnect.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.btnConnect.Location = new System.Drawing.Point(408, 27);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 30);
			this.btnConnect.TabIndex = 4;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.OnConnectButtonClick);
			// 
			// rTxtContent
			// 
			this.rTxtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
			this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblName.Location = new System.Drawing.Point(197, 34);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(52, 18);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtName.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtName.Location = new System.Drawing.Point(255, 34);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(149, 19);
			this.txtName.TabIndex = 3;
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.btnDisconnect.Location = new System.Drawing.Point(489, 27);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(102, 30);
			this.btnDisconnect.TabIndex = 5;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.OnDisconnectButtonClick);
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
			this.picBoxStatus.Image = global::AsyncChat.Client.Properties.Resources.power_cord_red;
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
			// ChatForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 292);
			this.Controls.Add(this.lblConnectionStatus);
			this.Controls.Add(this.picBoxStatus);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.rTxtContent);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.lblIP);
			this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ChatForm";
			this.Text = "Chattie";
			((System.ComponentModel.ISupportInitialize)(this.picBoxStatus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblIP;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.RichTextBox rTxtContent;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnDisconnect;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.PictureBox picBoxStatus;
		private System.Windows.Forms.Label lblConnectionStatus;
	}
}

