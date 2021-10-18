using DAL.Database;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
	{
		private ApplicationDbContext _context;
		private DbSet<TEntity> _dbSet;

		public GenericRepository(ApplicationDbContext context, DbSet<TEntity> dbSet)
		{
			_context = context;
			_dbSet = dbSet;
		}

		public async Task<TEntity> CreateAsync(TEntity entity)
		{
			await _dbSet.AddAsync(entity);
			await _context.SaveChangesAsync();

			return entity;
		}

		public async Task<TEntity> DeleteAsync(TEntity entity)
		{
			_dbSet.Remove(entity);
			await _context.SaveChangesAsync();

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

		public async Task<TEntity> UpdateAsync(TEntity entity)
		{
			_dbSet.Update(entity);
			await _context.SaveChangesAsync();

			return entity;
		}
	}
}
