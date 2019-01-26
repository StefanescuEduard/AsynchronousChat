using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AsyncChat.Domain
{
	public class MessageCryptor
	{
		private readonly Rfc2898DeriveBytes deriveBytes;
		private const string password = "ChattiePassword";
		private const string salt = "ChattieSalt";

		public MessageCryptor()
		{
			deriveBytes = new Rfc2898DeriveBytes(password, Encoding.Unicode.GetBytes(salt));
		}

		public byte[] EncryptMessage(byte[] message)
		{
			if (message == null || message.Length == 0)
			{
				throw new ArgumentNullException("Message is null");
			}

			byte[] encryptedData;

			using (var rijndael = new RijndaelManaged())
			{
				rijndael.KeySize = 256;
				rijndael.BlockSize = 128;
				rijndael.Key = deriveBytes.GetBytes(rijndael.KeySize / 8);
				rijndael.IV = deriveBytes.GetBytes(rijndael.BlockSize / 8);
				rijndael.Padding = PaddingMode.PKCS7;

				var encryptor = rijndael.CreateEncryptor();
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
					{
						cryptoStream.Write(message, 0, message.Length);
						cryptoStream.FlushFinalBlock();

						encryptedData = memoryStream.ToArray();
					}
				}
			}

			return encryptedData;
		}

		public string DecryptMessage(byte[] encryptedData)
		{
			if (encryptedData == null || encryptedData.Length == 0)
			{
				throw new ArgumentNullException("Message is null");
			}

			var decryptedMessage = new byte[encryptedData.Length];

			using (var rijndael = new RijndaelManaged())
			{
				rijndael.KeySize = 256;
				rijndael.BlockSize = 128;
				rijndael.Key = deriveBytes.GetBytes(rijndael.KeySize / 8);
				rijndael.IV = deriveBytes.GetBytes(rijndael.BlockSize / 8);
				rijndael.Padding = PaddingMode.PKCS7;

				var encryptor = rijndael.CreateDecryptor();
				using (MemoryStream memoryStream = new MemoryStream(encryptedData))
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Read))
					{
						cryptoStream.Read(decryptedMessage, 0, decryptedMessage.Length);
					}
				}
			}

			return Encoding.Unicode.GetString(decryptedMessage).Replace("\0", "");
		}
	}
}
