using AsyncChat.Entities.Domain;
using System.Data.Entity;

namespace AsyncChat.Persistence
{
	public class AsyncChatContext : DbContext
	{
		public DbSet<User> Users { get; set; }

		public AsyncChatContext() : base("AsyncChatConnection")
		{

		}
	}
}
