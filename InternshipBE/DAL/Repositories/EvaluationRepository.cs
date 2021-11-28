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
        private readonly IValidator<Evaluation> _validator;

        public EvaluationRepository(ApplicationDbContext context, IValidator<Evaluation> validator) : base(context)
        {
            _validator = validator;
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

        public async Task<int> DeleteMissingEvaluationsByFeedbackId(int feedbackId, List<Evaluation> evaluations)
        {
            var evaluationsToDelete = await _context.Evaluations
                .Where(x => x.FeedbackId == feedbackId && !evaluations.Select(x => x.Id).Contains(x.Id))
                .ToListAsync();

            _context.Evaluations.RemoveRange(evaluationsToDelete);

            return await _context.SaveChangesAsync();
        }

        public async override Task BulkSaveAsync(List<Evaluation> evaluations)
        {
            _validator.ValidateIfEntitesExist(evaluations);

            evaluations.ForEach(x => x.Skill = _context.Skills.FirstOrDefault(y => y.Id == x.Id));
            await base.BulkSaveAsync(evaluations);
        }
    }
}
