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

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().Property(user => user.Name).HasColumnType("VARCHAR");
			modelBuilder.Entity<User>().HasIndex(user => user.Name).IsUnique(true);
		}
	}
}
