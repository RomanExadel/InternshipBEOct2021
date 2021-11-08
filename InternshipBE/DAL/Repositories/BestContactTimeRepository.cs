using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class BestContactTimeRepository : GenericRepository<BestContactTime>, IBestContactTimeRepository
	{
		public BestContactTimeRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<List<BestContactTime>> GetAllByUserIdAsync(string userId)
		{
			return await _context.BestContactTimes.Where(x => x.User.Id == userId).ToListAsync();
		}
	}
}