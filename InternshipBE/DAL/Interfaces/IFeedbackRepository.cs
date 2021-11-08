using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IFeedbackRepository: IGenericRepository<Feedback>
    {
        Task<List<Feedback>> GetFeedbacksByCandidateIdAsync(int id);
    }
}
