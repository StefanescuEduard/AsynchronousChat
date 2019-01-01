using AsyncChat.Presentation.Properties;
using System.Windows.Forms;

namespace AsyncChat.Presentation.Views
{
	public partial class LoginView : UserControl
	{
		public LoginView()
		{
			InitializeComponent();
		}

		private void OnButtonLoginClick(object sender, System.EventArgs e)
		{
			if (!AreCredentialsEntered())
			{
				return;
			}

		}

		private bool AreCredentialsEntered()
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				MessageBox.Show(this, Resources.Warning_Title_EmptyName, Resources.Warning_EmptyName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (string.IsNullOrEmpty(txtPassword.Text))
			{
				MessageBox.Show(this, Resources.Warning_Title_EmptyPassword, Resources.Warning_EmptyPassword, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			return true;
		}
	}
}
