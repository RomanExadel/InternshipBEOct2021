using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class InterviewInviteRepository : GenericRepository<InterviewInvite>, IInterviewInviteRepository
    {
        public InterviewInviteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
