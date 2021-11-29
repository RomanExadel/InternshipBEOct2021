using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class InterviewInviteRepository : GenericRepository<InterviewInvite>, IInterviewInviteRepository
    {
        public InterviewInviteRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async override Task<List<InterviewInvite>> GetAllAsync()
        {
            return await _context.InterviewInvites
                .AsNoTracking()
                .Include(x => x.User)
                .Include(x => x.Candidate)
                .ToListAsync();
        }
    }
}
