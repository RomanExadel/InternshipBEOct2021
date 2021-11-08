using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class FeedbackRepository : GenericRepository<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<Feedback>> GetFeedbacksByCandidateIdAsync(int id)
        {
            return await _context.Feedbacks.Where(x => x.CandidateId == id).ToListAsync();
        }
    }
}
