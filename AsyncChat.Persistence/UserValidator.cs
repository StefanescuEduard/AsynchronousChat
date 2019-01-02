using AsyncChat.Domain;
using AsyncChat.Domain.Entities;
using AsyncChat.Persistence.Repository;
using System.Threading.Tasks;

namespace AsyncChat.Persistence
{
	public class UserValidator
	{
		private readonly PasswordEncrypter passwordEncrypter;

		public UserValidator()
		{
			passwordEncrypter = new PasswordEncrypter();
		}

		public async Task<bool> Validate(User user)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var dbUser = await unitOfWork.UserRepository.GetUserAsync(user.Name);
				if (dbUser == null)
				{
					return false;
				}
				if (user.Name != dbUser.Name)
				{
					return false;
				}

				return await ValidatePassword(user.Password, dbUser.Password);
			}
		}

		private async Task<bool> ValidatePassword(string localUserPassword, string dbUserPassword)
		{
			var encryptedLocalPassword = await Task.Run(() => passwordEncrypter.EncryptPassword(localUserPassword));

			if (encryptedLocalPassword != dbUserPassword)
			{
				return false;
			}

			return true;
		}
	}
}
