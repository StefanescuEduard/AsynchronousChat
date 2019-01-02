using AsyncChat.Domain.Entities;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AsyncChat.Persistence.Repository
{
	public class UserRepository : Repository<User>
	{
		private AsyncChatContext AsyncChatContext => DbContext as AsyncChatContext;

		public UserRepository(AsyncChatContext asyncChatContext) : base(asyncChatContext)
		{

		}

		public async Task<User> GetUserAsync(string name)
		{
			return await AsyncChatContext.Users.FirstOrDefaultAsync(user => user.Name == name);
		}
	}
}
