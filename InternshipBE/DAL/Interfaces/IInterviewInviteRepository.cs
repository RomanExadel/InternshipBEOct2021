using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IInterviewInviteRepository : IGenericRepository<InterviewInvite>
    {
        Task<List<InterviewInvite>> GetAllByUserIdAsync(string userId);
    }
}
