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
			this.lblName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnCreateAccount = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.registerView = new AsyncChat.Presentation.Views.RegisterView();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblName.Location = new System.Drawing.Point(15, 65);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(52, 18);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblPassword.Location = new System.Drawing.Point(15, 120);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(78, 18);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Password:";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtName.Location = new System.Drawing.Point(18, 86);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(262, 26);
			this.txtName.TabIndex = 2;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtPassword.Location = new System.Drawing.Point(18, 141);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '•';
			this.txtPassword.Size = new System.Drawing.Size(262, 26);
			this.txtPassword.TabIndex = 3;
			// 
			// btnCreateAccount
			// 
			this.btnCreateAccount.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.btnCreateAccount.Location = new System.Drawing.Point(18, 178);
			this.btnCreateAccount.Name = "btnCreateAccount";
			this.btnCreateAccount.Size = new System.Drawing.Size(125, 28);
			this.btnCreateAccount.TabIndex = 4;
			this.btnCreateAccount.Text = "Create account";
			this.btnCreateAccount.UseVisualStyleBackColor = true;
			this.btnCreateAccount.Click += new System.EventHandler(this.OnButtonRegisterClick);
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.btnLogin.Location = new System.Drawing.Point(205, 178);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 28);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.OnButtonLoginClick);
			// 
			// registerView
			// 
			this.registerView.Location = new System.Drawing.Point(0, 0);
			this.registerView.Name = "registerView";
			this.registerView.Size = new System.Drawing.Size(300, 300);
			this.registerView.TabIndex = 6;
			this.registerView.Visible = false;
			// 
			// LoginView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.registerView);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnCreateAccount);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblName);
			this.Margin = new System.Windows.Forms.Padding(50, 3, 15, 3);
			this.Name = "LoginView";
			this.Size = new System.Drawing.Size(300, 300);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnCreateAccount;
		private System.Windows.Forms.Button btnLogin;
		private RegisterView registerView;
	}
}
