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
			return await _context.BestContactTimes.Include(x => x.User).Where(x => x.UserId == userId).ToListAsync();
		}

		public async Task<BestContactTime> GetByTimeIntervalAsync(BestContactTime contactTime)
		{
			return await _context.BestContactTimes.Where(x => x.StartTime == contactTime.StartTime && x.EndTime == contactTime.EndTime)
				.FirstOrDefaultAsync(x => x.UserId == contactTime.UserId);
		}

		public async Task DeleteByIdAsync(int bestContactTimeId)
		{
			var bestTime = await _context.BestContactTimes.FirstOrDefaultAsync(x => x.Id == bestContactTimeId);
			_context.BestContactTimes.Remove(bestTime);

			await _context.SaveChangesAsync();
		}
	}
}