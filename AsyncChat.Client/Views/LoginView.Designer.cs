namespace AsyncChat.Presentation.Views
{
	partial class LoginView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
			this.lblName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnCreateAccount = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblName.Location = new System.Drawing.Point(15, 89);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(52, 18);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblPassword.Location = new System.Drawing.Point(15, 144);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(78, 18);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password:";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtName.Location = new System.Drawing.Point(18, 110);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(262, 26);
			this.txtName.TabIndex = 1;
			this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTxtNameKeyDown);
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtPassword.Location = new System.Drawing.Point(18, 165);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '•';
			this.txtPassword.Size = new System.Drawing.Size(262, 26);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTxtPasswordKeyDown);
			// 
			// btnCreateAccount
			// 
			this.btnCreateAccount.Depth = 0;
			this.btnCreateAccount.Location = new System.Drawing.Point(18, 202);
			this.btnCreateAccount.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnCreateAccount.Name = "btnCreateAccount";
			this.btnCreateAccount.Primary = true;
			this.btnCreateAccount.Size = new System.Drawing.Size(125, 28);
			this.btnCreateAccount.TabIndex = 5;
			this.btnCreateAccount.Text = "Create account";
			this.btnCreateAccount.UseVisualStyleBackColor = true;
			this.btnCreateAccount.Click += new System.EventHandler(this.OnButtonRegisterClick);
			// 
			// btnLogin
			// 
			this.btnLogin.Depth = 0;
			this.btnLogin.Location = new System.Drawing.Point(205, 202);
			this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Primary = true;
			this.btnLogin.Size = new System.Drawing.Size(75, 28);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.OnButtonLoginClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(96, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(95, 95);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// LoginView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnCreateAccount);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblName);
			this.Margin = new System.Windows.Forms.Padding(50, 3, 15, 3);
			this.Name = "LoginView";
			this.Size = new System.Drawing.Size(300, 265);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPassword;
		private MaterialSkin.Controls.MaterialRaisedButton btnCreateAccount;
		private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
