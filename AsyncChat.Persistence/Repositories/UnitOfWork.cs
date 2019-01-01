using System;

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

		public void Commit()
		{
			asyncChatContext.SaveChanges();
		}

		public void Dispose()
		{
			asyncChatContext?.Dispose();
		}
	}
}
