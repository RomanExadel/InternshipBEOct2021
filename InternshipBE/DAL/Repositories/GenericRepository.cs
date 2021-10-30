using DAL.Database;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
	{
		protected readonly ApplicationDbContext _context;
		private readonly DbSet<TEntity> _dbSet;

		public GenericRepository(ApplicationDbContext context)
		{
			_context = context;
			_dbSet = _context.Set<TEntity>();
		}

		public async Task<TEntity> CreateAsync(TEntity entity)
		{
			await _dbSet.AddAsync(entity);

			return entity;
		}

		public async Task<TEntity> DeleteAsync(TEntity entity)
		{
			await Task.Run(() => _dbSet.Remove(entity));

			return entity;
		}

		public async Task<List<TEntity>> GetAllAsync()
		{
			return await _dbSet.AsNoTracking().ToListAsync();
		}

		public async Task<TEntity> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public async Task RangeSaveAsync(List<TEntity> entities)
		{
			await _dbSet.AddRangeAsync(entities);
			await _context.SaveChangesAsync();
		}

		public async Task<TEntity> UpdateAsync(TEntity entity)
		{
			await Task.Run(() => _dbSet.Update(entity));

			return entity;
		}
	}
}
