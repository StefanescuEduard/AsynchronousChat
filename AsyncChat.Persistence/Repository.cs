using System.Data.Entity;

namespace AsyncChat.Persistence
{
	public class Repository<TEntity> where TEntity : class
	{
		protected readonly DbContext DbContext;

		public Repository(DbContext dbContext)
		{
			this.DbContext = dbContext;
		}

		public void Add(TEntity entity)
		{
			DbContext.Set<TEntity>().Add(entity);
		}
	}
}
