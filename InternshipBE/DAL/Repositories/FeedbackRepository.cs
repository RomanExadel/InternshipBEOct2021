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

        public override async Task<Feedback> GetByIdAsync(int id)
        {
            return await _context.Feedbacks
                .AsNoTracking()
                .Include(x => x.Candidate)
                .Include(x => x.Evaluations)
                .ThenInclude(x => x.Skill)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Feedback>> GetFeedbacksByCandidateIdAsync(int id)
        {
            return await _context.Feedbacks
                .AsNoTracking()
                .Include(x => x.Evaluations)
                .ThenInclude(x => x.Skill)
                .Where(x => x.CandidateId == id)
                .ToListAsync();
        }
    }
}
