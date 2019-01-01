using AsyncChat.Domain.Entities;
using System.Linq;

namespace AsyncChat.Persistence.Repository
{
	public class UserRepository : Repository<User>
	{
		private AsyncChatContext AsyncChatContext => DbContext as AsyncChatContext;

		public UserRepository(AsyncChatContext asyncChatContext) : base(asyncChatContext)
		{

		}

		public User GetUser(string name)
		{
			return AsyncChatContext.Users.FirstOrDefault(user => user.Name == name);
		}
	}
}
