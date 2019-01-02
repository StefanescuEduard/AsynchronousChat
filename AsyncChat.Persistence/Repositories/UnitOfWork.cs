using System;
using System.Threading.Tasks;

namespace AsyncChat.Persistence.Repository
{
	public class UnitOfWork : IDisposable
	{
		private readonly AsyncChatContext asyncChatContext;

		public UserRepository UserRepository { get; private set; }

		public UnitOfWork()
		{
			asyncChatContext = new AsyncChatContext();
			UserRepository = new UserRepository(asyncChatContext);
		}

		public async Task Commit()
		{
			await asyncChatContext.SaveChangesAsync();
		}

		public async void Dispose()
		{
			await Task.Run(() => asyncChatContext?.Dispose());
		}
	}
}
