using System.Data.Entity;
using System.Threading.Tasks;

namespace AsyncChat.Persistence.Repository
{
	public class Repository<TEntity> where TEntity : class
	{
		protected readonly DbContext DbContext;

		public Repository(DbContext dbContext)
		{
			this.DbContext = dbContext;
		}

		public async Task AddAsync(TEntity entity)
		{
			await Task.Run(() => DbContext.Set<TEntity>().Add(entity));
		}
	}
}
