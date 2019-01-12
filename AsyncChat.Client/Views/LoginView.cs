using AsyncChat.Domain.Entities;
using AsyncChat.Persistence;
using AsyncChat.Presentation.Properties;
using System;
using System.Windows.Forms;

namespace AsyncChat.Presentation.Views
{
	public partial class LoginView : UserControl
	{
		private readonly UserValidator userValidator;
		private readonly RegisterView registerView;

		public LoginView()
		{
			InitializeComponent();

			registerView = new RegisterView();
			userValidator = new UserValidator();

			registerView.RegisterFinishedMethod += HideRegisterView;
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
			Controls.Add(registerView);
			registerView.BringToFront();
		}

		private void HideRegisterView()
		{
			Controls.Remove(registerView);
			registerView.SendToBack();
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
