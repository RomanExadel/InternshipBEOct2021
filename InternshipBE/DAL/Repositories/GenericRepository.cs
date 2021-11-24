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

		public virtual async Task<TEntity> CreateAsync(TEntity entity)
		{
			await _dbSet.AddAsync(entity);
			await _context.SaveChangesAsync();

			return entity;
		}

		public virtual async Task<TEntity> DeleteAsync(TEntity entity)
		{
			await Task.Run(() => _dbSet.Remove(entity));
			await _context.SaveChangesAsync();

			return entity;
		}

		public virtual async Task<List<TEntity>> GetAllAsync()
		{
			return await _dbSet.AsNoTracking().ToListAsync();
		}

		public virtual async Task<TEntity> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public virtual async Task BulkSaveAsync(List<TEntity> entities)
		{
			await _dbSet.AddRangeAsync(entities);
			await _context.SaveChangesAsync();
		}

		public virtual async Task<TEntity> UpdateAsync(TEntity entity)
		{
			await Task.Run(() => _dbSet.Update(entity));
			await _context.SaveChangesAsync();

			return entity;
		}

		public async Task DeleteByIdAsync(int Id)
		{
			var entity = await _dbSet.FindAsync(Id);
			_dbSet.Remove(entity);

			await _context.SaveChangesAsync();
		}

		public async Task<List<TEntity>> BulkUpdateAsync(List<TEntity> entities)
		{
			_dbSet.UpdateRange(entities);

			await _context.SaveChangesAsync();

			return entities;
		}
	}
}
