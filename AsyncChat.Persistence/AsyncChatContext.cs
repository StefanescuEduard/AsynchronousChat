using AsyncChat.Domain.Entities;
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
