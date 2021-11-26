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

        public async override Task<Feedback> UpdateAsync(Feedback newFeedback)
        {
            //var feedback = await _context.Feedbacks.FindAsync(newFeedback.Id);
            var feedback = await _context.Feedbacks
                .Include(x => x.Candidate)
                .Include(x => x.Evaluations)
                .ThenInclude(x => x.Skill)
                .AsNoTracking()
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == newFeedback.Id);

            var oldEvaluations = new List<Evaluation>(feedback.Evaluations);

            feedback.CandidateId = newFeedback.CandidateId;
            feedback.Candidate = await _context.Candidates.FindAsync(newFeedback.CandidateId);
            feedback.Date = newFeedback.Date;
            feedback.Description = newFeedback.Description;
            feedback.EnglishLevelType = newFeedback.EnglishLevelType;
            feedback.FinalEvaluation = newFeedback.FinalEvaluation;
            feedback.UserId = newFeedback.UserId;
            feedback.User = await _context.Users.FindAsync(newFeedback.UserId);
            feedback.Evaluations.Clear();

            newFeedback.Evaluations.ToList().ForEach(x => x.Skill = null);

            if (newFeedback.Evaluations != null)
            {
                var newEvaluations = newFeedback.Evaluations.Where(x => x.Id == 0);
                await _context.Evaluations.AddRangeAsync(newEvaluations);

                var evaluations = await _context.Evaluations
                    .Where(x => newFeedback.Evaluations.Select(x => x.Id).Contains(x.Id))
                    .ToListAsync();
                evaluations.AddRange(newEvaluations);

                var evaluationIdsToDelelte = oldEvaluations.Select(x => x.Id)
                                                           .Except(evaluations.Select(x => x.Id))
                                                           .ToList();
                var evaluationsToDelelte = oldEvaluations.Where(x => evaluationIdsToDelelte.Contains(x.Id));
                _context.Evaluations.RemoveRange(evaluationsToDelelte);

                evaluations.ForEach(x => feedback.Evaluations.Add(x));
            }

            _context.Entry(feedback).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return feedback;
        }
    }
}
