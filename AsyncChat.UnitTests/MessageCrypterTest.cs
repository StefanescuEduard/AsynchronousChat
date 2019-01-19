using AsyncChat.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace AsyncChat.UnitTests
{
	[TestClass]
	public class MessageCrypterTest
	{
		[TestMethod]
		public void MessageIsEncryptedAndDecryptedSuccessfully()
		{
			var messageCrypterFirstInstance = new MessageCryptor();
			var messageCrypterSecondInstance = new MessageCryptor();
			const string message = "SomeMessage";

			var encryptedMessage = messageCrypterFirstInstance.EncryptMessage(message);
			var decryptedMessage = Encoding.Unicode.GetString(messageCrypterSecondInstance.DecryptMessage(encryptedMessage));

			Assert.AreEqual(message, decryptedMessage);
		}
	}
}
