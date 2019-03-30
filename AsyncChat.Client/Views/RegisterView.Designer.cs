namespace AsyncChat.WindowsForms.Views
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
			this.btnRegister = new MaterialSkin.Controls.MaterialRaisedButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtName.Location = new System.Drawing.Point(21, 72);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(262, 26);
			this.txtName.TabIndex = 4;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblName.ForeColor = System.Drawing.Color.White;
			this.lblName.Location = new System.Drawing.Point(18, 51);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(52, 18);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Name:";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtEmail.Location = new System.Drawing.Point(21, 128);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(262, 26);
			this.txtEmail.TabIndex = 6;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.BackColor = System.Drawing.Color.Transparent;
			this.lblEmail.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblEmail.ForeColor = System.Drawing.Color.White;
			this.lblEmail.Location = new System.Drawing.Point(18, 107);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(50, 18);
			this.lblEmail.TabIndex = 5;
			this.lblEmail.Text = "Email:";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.txtPassword.Location = new System.Drawing.Point(21, 186);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '•';
			this.txtPassword.Size = new System.Drawing.Size(262, 26);
			this.txtPassword.TabIndex = 8;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblPassword.Font = new System.Drawing.Font("Roboto", 11.25F);
			this.lblPassword.ForeColor = System.Drawing.Color.White;
			this.lblPassword.Location = new System.Drawing.Point(18, 165);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(78, 18);
			this.lblPassword.TabIndex = 7;
			this.lblPassword.Text = "Password:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::AsyncChat.WindowsForms.Properties.Resources.PersonAdd;
			this.pictureBox1.Location = new System.Drawing.Point(110, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// btnBack
			// 
			this.btnBack.Depth = 0;
			this.btnBack.Location = new System.Drawing.Point(21, 229);
			this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnBack.Name = "btnBack";
			this.btnBack.Primary = true;
			this.btnBack.Size = new System.Drawing.Size(71, 27);
			this.btnBack.TabIndex = 12;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.OnButtonBackClick);
			// 
			// btnRegister
			// 
			this.btnRegister.Depth = 0;
			this.btnRegister.Location = new System.Drawing.Point(208, 229);
			this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Primary = true;
			this.btnRegister.Size = new System.Drawing.Size(75, 27);
			this.btnRegister.TabIndex = 13;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.OnRegisterButtonClickAsync);
			// 
			// RegisterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Name = "RegisterView";
			this.Size = new System.Drawing.Size(300, 300);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private MaterialSkin.Controls.MaterialRaisedButton btnBack;
		private MaterialSkin.Controls.MaterialRaisedButton btnRegister;
	}
}
