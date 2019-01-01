namespace AsyncChat.Presentation.Views
{
	partial class RegisterView
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtName.Location = new System.Drawing.Point(21, 57);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(262, 26);
			this.txtName.TabIndex = 4;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblName.Location = new System.Drawing.Point(18, 36);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(52, 18);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Name:";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtEmail.Location = new System.Drawing.Point(21, 113);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(262, 26);
			this.txtEmail.TabIndex = 6;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblEmail.Location = new System.Drawing.Point(18, 92);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(50, 18);
			this.lblEmail.TabIndex = 5;
			this.lblEmail.Text = "Email:";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtPassword.Location = new System.Drawing.Point(21, 171);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(262, 26);
			this.txtPassword.TabIndex = 8;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblPassword.Location = new System.Drawing.Point(18, 150);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(78, 18);
			this.lblPassword.TabIndex = 7;
			this.lblPassword.Text = "Password:";
			// 
			// btnRegister
			// 
			this.btnRegister.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.btnRegister.Location = new System.Drawing.Point(208, 212);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(75, 28);
			this.btnRegister.TabIndex = 9;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.btnBack.Location = new System.Drawing.Point(21, 212);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 28);
			this.btnBack.TabIndex = 10;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			// 
			// RegisterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Name = "RegisterView";
			this.Size = new System.Drawing.Size(300, 300);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnBack;
	}
}
