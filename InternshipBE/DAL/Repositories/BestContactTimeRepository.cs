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
			return await _context.BestContactTimes.Include(x => x.User).ToListAsync();
		}

		public async Task<BestContactTime> GetByTimeIntervalAsync(BestContactTime contactTime)
		{
			return await _context.BestContactTimes.Where(x => x.StartTime.ToString("G") == contactTime.StartTime.ToString("G"))
				.Where(x => x.EndTime.ToString("G") == contactTime.EndTime.ToString("G"))
				.FirstAsync(x => x.UserId == contactTime.UserId);
		}
	}
}