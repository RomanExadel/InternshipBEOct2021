using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IInterviewInviteService
    {
        Task<List<InterviewInviteDTO>> GetAllInterviewInvitesAsync();
    }
}
