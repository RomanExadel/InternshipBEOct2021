using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IGenericRepository<TEntity> where TEntity : class
	{
		public Task<TEntity> CreateAsync(TEntity entity);

		public Task<TEntity> GetByIdAsync(int id);

		public Task<List<TEntity>> GetAllAsync();

		public Task<TEntity> UpdateAsync(TEntity entity);

		public Task<TEntity> DeleteAsync(TEntity entity);

		public Task BulkSaveAsync(List<TEntity> entities);

		Task DeleteByIdAsync(int Id);
	}
}
