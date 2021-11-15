using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<Candidate>> GetCandidatesByInternshipIdAsync(int id, int pageSize, int pageNumber)
        {
            var internship = await _context.Internships.Include(x => x.Candidates).FirstOrDefaultAsync(x => x.Id == id);

            return internship?.Candidates.Skip(pageSize * --pageNumber).Take(pageSize).ToList();
        }

        public async Task<List<Candidate>> GetCandidatesByInternshipIdAsync(int internshipId, ReportType reportType)
        {
            CandidateStatusType? statusType = GetStatusType(reportType);

            var internship = await _context.Internships.AsNoTracking()
                                                       .Include(x => x.Candidates.Where(r => r.StatusType == statusType || statusType == null))
                                                       .FirstOrDefaultAsync(x => x.Id == internshipId);

            return internship?.Candidates.ToList();
        }

        public async Task<int> GetCandidatesCountAsync()
        {
            return await _context.Candidates.CountAsync();
        }

        public IQueryable<Candidate> GetAllCandidates()
        {
            return _context.Candidates
                .Include(x => x.Users)
                .Include(x => x.Team)
                .AsQueryable();
        }

        private CandidateStatusType? GetStatusType(ReportType reportType)
        {
            if (reportType == ReportType.CandidatesAccepted)
                return CandidateStatusType.Accepted;
            else if (reportType == ReportType.CandidatesRejection)
                return CandidateStatusType.Declined;
            else return null;
        }
    }
}