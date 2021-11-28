using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IEvaluationRepository : IGenericRepository<Evaluation>
    {
        Task<List<Evaluation>> GetEvaluationsByFeedbackId (int feedbackId);

        Task<int> DeleteMissingEvaluationsByFeedbackId(int feedbackId, List<Evaluation> evaluations);
    }
}
