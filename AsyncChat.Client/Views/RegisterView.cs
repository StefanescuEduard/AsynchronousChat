﻿using AsyncChat.Domain;
using AsyncChat.Domain.Entities;
using AsyncChat.Persistence.Repository;
using AsyncChat.Presentation.Properties;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncChat.Presentation.Views
{
	public partial class RegisterView : UserControl
	{
		private readonly PasswordEncrypter passwordEncrypter;

		public RegisterView()
		{
			InitializeComponent();

			passwordEncrypter = new PasswordEncrypter();
		}

		private async void OnRegisterButtonClickAsync(object sender, EventArgs e)
		{
			if (!AreAllFieldsEntered())
			{
				return;
			}

			await SaveUserAsync();
			ResetInputControls();
			RegisterFinishedMethod.Invoke();
		}

		private void OnButtonBackClick(object sender, EventArgs e)
		{
			ResetInputControls();
			RegisterFinishedMethod.Invoke();
		}

		private async Task SaveUserAsync()
		{
			var user = new User
			{
				Name = txtName.Text,
				Email = txtEmail.Text,
				Password = passwordEncrypter.EncryptPassword(txtPassword.Text)
			};

			using (var unitOfWork = new UnitOfWork())
			{
				await unitOfWork.UserRepository.AddAsync(user);
				unitOfWork.Commit();
			}

			MessageBox.Show(this, Resources.Information_AccountCreated, Resources.Information_Title_AccountCreated,
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private bool AreAllFieldsEntered()
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				MessageBox.Show(this, Resources.Warning_EmptyName, Resources.Warning_Title_EmptyName,
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (string.IsNullOrEmpty(txtEmail.Text))
			{
				MessageBox.Show(this, Resources.Warning_EmptyEmail, Resources.Warning_Title_EmptyEmail,
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

		private void ResetInputControls()
		{
			txtName.Text = string.Empty;
			txtEmail.Text = string.Empty;
			txtPassword.Text = string.Empty;
		}

		public delegate void RegisterFinished();
		public RegisterFinished RegisterFinishedMethod;
	}
}
