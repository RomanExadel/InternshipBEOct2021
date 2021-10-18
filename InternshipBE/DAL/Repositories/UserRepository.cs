using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
	public class UserRepository : GenericRepository<User>, IUserRepository
	{
		private UserManager<User> _userManager;
		private ApplicationDbContext _context;
		private DbSet<User> _dbSet;

		public UserRepository(UserManager<User> userManager, DbSet<User> dbSet, ApplicationDbContext context)
				: base(context, dbSet)
		{
			_userManager = userManager;
			_dbSet = dbSet;
			_context = context;
		}
	}
}
