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
        private readonly IValidator<Feedback> _validator;

        public FeedbackRepository(ApplicationDbContext context, IValidator<Feedback> validator) : base(context)
        {
            _validator = validator;
        }

        public override async Task<Feedback> GetByIdAsync(int id)
        {
            var feedback = await _context.Feedbacks
                .AsNoTracking()
                .Include(x => x.Candidate)
                .Include(x => x.Evaluations)
                .ThenInclude(x => x.Skill)
                .FirstOrDefaultAsync(x => x.Id == id);

            _validator.ValidateIfEntityExist(feedback);

            return feedback;
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
