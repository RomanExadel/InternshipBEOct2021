using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class UserRepository : GenericRepository<User>, IUserRepository
	{
		public UserRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<User> GetUserWithBestContactTimeByIdAsync(string userId)
		{
			return await _context.Users.Include(x => x.BestContactTimes).FirstOrDefaultAsync(x => x.Id == userId);
		}
	}
}
