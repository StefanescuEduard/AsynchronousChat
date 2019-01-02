﻿using AsyncChat.Domain.Entities;
using AsyncChat.Persistence;
using AsyncChat.Presentation.Properties;
using System;
using System.Windows.Forms;

namespace AsyncChat.Presentation.Views
{
	public partial class LoginView : UserControl
	{
		private readonly UserValidator userValidator;

		public LoginView()
		{
			InitializeComponent();
			registerView.RegisterFinishedMethod += HideRegisterView;
			userValidator = new UserValidator();
		}

		private async void OnButtonLoginClick(object sender, EventArgs e)
		{
			if (!AreCredentialsEntered())
			{
				return;
			}

			var user = new User
			{
				Name = txtName.Text,
				Password = txtPassword.Text
			};

			var isUserValid = await userValidator.Validate(user);

			if (!isUserValid)
			{
				MessageBox.Show(this, Resources.Warning_IncorrectCredentials, Resources.Warning_Title_IncorrectCredentials,
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			UserLogedMethod.Invoke(txtName.Text);
			ResetInputControls();
		}

		private bool AreCredentialsEntered()
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				MessageBox.Show(this, Resources.Warning_EmptyName, Resources.Warning_Title_EmptyName,
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (string.IsNullOrEmpty(txtPassword.Text))
			{
				MessageBox.Show(this, Resources.Warning_EmptyPassword, Resources.Warning_Title_EmptyPassword,
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}

		private void OnButtonRegisterClick(object sender, EventArgs e)
		{
			registerView.Visible = true;
		}

		private void HideRegisterView()
		{
			registerView.Visible = false;
		}

		private void ResetInputControls()
		{
			txtName.Text = string.Empty;
			txtPassword.Text = string.Empty;
		}

		public delegate void UserLoged(string userName);
		public UserLoged UserLogedMethod;
	}
}
