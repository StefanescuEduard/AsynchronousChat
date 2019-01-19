using System;
using System.Security.Cryptography;
using System.Text;
using TBB.Rijndael256.Core;
using Rijndael = TBB.Rijndael256.Core.Rijndael;

namespace AsyncChat.Domain
{
	public class MessageCryptor
	{
		public MessageCryptor()
		{
		}

		public byte[] EncryptMessage(string message)
		{
			if (string.IsNullOrEmpty(message))
			{
				throw new ArgumentNullException("Message is null");
			}

			using (var rijndael = new RijndaelManaged())
			{
				rijndael.GenerateIV();
				return Rijndael.Encrypt(Encoding.Unicode.GetBytes(message), "Password", rijndael.IV, KeySize.Aes128);
			}

		}

		public byte[] DecryptMessage(byte[] encryptedData)
		{
			if (encryptedData == null || encryptedData.Length == 0)
			{
				throw new ArgumentNullException("EncryptedData is null");
			}

			return Rijndael.Decrypt(encryptedData, "Password", KeySize.Aes128);
		}
	}
}
