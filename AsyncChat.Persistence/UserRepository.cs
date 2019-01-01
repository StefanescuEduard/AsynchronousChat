using AsyncChat.Domain;
using System.Linq;

namespace AsyncChat.Persistence
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
