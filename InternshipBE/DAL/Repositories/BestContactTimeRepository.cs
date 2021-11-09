using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

		public async Task<BestContactTime> GetByTimeIntervalAsync(DateTime startTime, DateTime endTime)
		{
			return await _context.BestContactTimes.FirstOrDefaultAsync(x => x.StartTime == startTime && x.EndTime == endTime);
		}
	}
}