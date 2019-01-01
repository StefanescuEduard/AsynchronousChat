using AsyncChat.Client.Properties;
using AsyncChat.Domain;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AsyncChat.Client
{
	public partial class ChatForm : Form
	{
		private AsyncClient asyncClient;
		private bool exceptionThrown = false;

		public ChatForm()
		{
			InitializeComponent();
			InitializeControls();
			ShowLoginView();

			asyncClient = new AsyncClient();
			asyncClient.ExceptionThrownMethod += HandleException;
			asyncClient.ChatContentReceivedMethod += DisplayChatContent;
			asyncClient.ConnectionIvokedMethod += HandleConnection;
		}

		private void InitializeControls()
		{
			rTxtContent.BackColor = Color.White;
			txtMessage.Text = string.Empty;
			txtIP.Enabled = true;
			btnConnect.Enabled = true;
			btnDisconnect.Enabled = false;
			txtMessage.Enabled = false;
			btnSend.Enabled = false;
			HandleConnection(false);
		}

		private void OnConnectButtonClick(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtIP.Text))
			{
				asyncClient.SetConnectionForClient(txtIP.Text);
				if (exceptionThrown)
				{
					exceptionThrown = !exceptionThrown;
					return;
				}
				asyncClient.Connect();
				SetControlsForConnection();
				exceptionThrown = false;
			}
			else
			{
				if (string.IsNullOrEmpty(txtIP.Text))
				{
					MessageBox.Show(this, Resources.Warning_EmptyIpAddress, Resources.Warning_Title_EmptyIpAddress,
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}
		}

		private void SetControlsForConnection()
		{
			txtIP.Enabled = false;
			btnConnect.Enabled = false;
			btnDisconnect.Enabled = true;
			txtMessage.Enabled = true;
			btnSend.Enabled = true;
		}

		private void OnDisconnectButtonClick(object sender, EventArgs e)
		{
			asyncClient.Send("disconnect");
			InitializeControls();
		}

		private void OnSendButtonClick(object sender, EventArgs e)
		{
			var message = txtMessage.Text;

			if (message.Equals("\r\n"))
			{
				return;
			}
			if (message.StartsWith("\r\n"))
			{
				message = message.TrimStart(new char[] { '\r', '\n' });
			}
			if (!string.IsNullOrEmpty(message))
			{
				//asyncClient.Send($"{txtName.Text}: {message}");
				txtMessage.Clear();
			}
		}

		public void DisplayChatContent()
		{
			Invoke((Action)delegate
			{
				rTxtContent.AppendText($"{asyncClient.ChatContent}\r\n");
			});
		}

		private void OnBackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			rTxtContent.AppendText($"{asyncClient.ChatContent}\r\n");
		}

		private void ShowLoginView()
		{
			panBackground.BringToFront();
			panBackground.BackColor = Color.FromArgb(5, 210, 218, 226);
			loginView.Visible = true;
		}

		private void OnChatContentBoxKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				OnSendButtonClick(sender, new EventArgs());
			}
		}

		private void OnChatContentTextChanged(object sender, EventArgs e)
		{
			rTxtContent.SelectionStart = rTxtContent.Text.Length;
			rTxtContent.ScrollToCaret();
		}

		private void HandleException(string exceptionMessage)
		{
			MessageBox.Show(this, exceptionMessage, "Something bad happened", MessageBoxButtons.OK, MessageBoxIcon.Error);
			exceptionThrown = true;
			InitializeControls();
		}

		private void HandleConnection(bool connected)
		{
			if (connected)
			{
				lblConnectionStatus.Text = "Connected";
				lblConnectionStatus.ForeColor = ColorTranslator.FromHtml("#0be881");
				picBoxStatus.Image = Resources.power_cord_green;
			}
			else
			{
				lblConnectionStatus.Text = "Disconnected";
				lblConnectionStatus.ForeColor = ColorTranslator.FromHtml("#ff3f34");
				picBoxStatus.Image = Resources.power_cord_red;
			}
		}
	}
}
