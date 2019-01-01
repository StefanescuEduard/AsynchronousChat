namespace AsyncChat.Domain
{
	public class PasswordEncrypter
	{
		public string EncryptPassword(string password)
		{
			return GodSharp.Encryption.MD5.Encrypt(password);
		}
	}
}
