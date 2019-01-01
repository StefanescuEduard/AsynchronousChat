using AsyncChat.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncChat.Persistence.Repository
{
	public class UserRepository : Repository<User>
	{
		private AsyncChatContext AsyncChatContext => DbContext as AsyncChatContext;

		public UserRepository(AsyncChatContext asyncChatContext) : base(asyncChatContext)
		{

		}

		public async Task<User> GetUser(string name)
		{
			return await Task.Run(() => AsyncChatContext.Users.FirstOrDefault(user => user.Name == name));
		}
	}
}
