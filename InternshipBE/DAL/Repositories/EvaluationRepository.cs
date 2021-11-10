using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EvaluationRepository : GenericRepository<Evaluation>, IEvaluationRepository
    {
        public EvaluationRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<Evaluation>> GetEvaluationsByFeedbackId(int feedbackId)
        {
            return await _context.Evaluations
                .AsNoTracking()
                .Include(x => x.Feedback)
                .Include(x => x.Skill)
                .Where(x => x.FeedbackId == feedbackId)
                .ToListAsync();
        }
    }
}
