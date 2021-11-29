using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public async override Task<InterviewInvite> CreateAsync(InterviewInvite invite)
        {
            invite.User = await _context.Users.FirstOrDefaultAsync(x => x.Id == invite.UserId);
            invite.Candidate = await _context.Candidates.FirstOrDefaultAsync(x => x.Id == invite.CandidateId);

            return await base.CreateAsync(invite);
        }

        public async override Task<InterviewInvite> UpdateAsync(InterviewInvite invite)
        {
            invite.User = await _context.Users.FirstOrDefaultAsync(x => x.Id == invite.UserId);
            invite.Candidate = await _context.Candidates.FirstOrDefaultAsync(x => x.Id == invite.CandidateId);

            return await base.UpdateAsync(invite);
        }

        public async Task<List<InterviewInvite>> GetAllByUserIdAsync(string userId)
        {
            return await _context.InterviewInvites
                .AsNoTracking()
                .Include(x => x.User)
                .Include(x => x.Candidate)
                .Where(x => x.UserId == userId)
                .ToListAsync();
        }
    }
}
