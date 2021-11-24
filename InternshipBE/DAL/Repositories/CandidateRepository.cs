using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using Shared.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        private readonly IValidator<Candidate> _validator;

        public CandidateRepository(ApplicationDbContext context, IValidator<Candidate> validator) : base(context)
        {
            _validator = validator;
        }

        public async override Task<Candidate> GetByIdAsync(int id)
        {
            var candidate = await _context.Candidates.AsNoTracking()
                .Include(x => x.Users)
                .FirstOrDefaultAsync(x => x.Id == id);

            _validator.ValidateIfEntityExist(candidate);

            return candidate;
        }

		public async Task<List<Candidate>> GetCandidatesByInternshipIdAsync(int id, int pageSize, int pageNumber)
		{
			return await _context.Candidates.AsNoTracking().Include(x => x.Internship)
				.Include(x => x.Users)
					.ThenInclude(x => x.Feedbacks.Where(x => x.Candidate.InternshipId == id))
						.ThenInclude(x => x.Evaluations)
				.Where(x => x.InternshipId == id)
				.Skip(pageSize * --pageNumber)
				.Take(pageSize)
				.ToListAsync();
		}

		public async Task<List<Candidate>> GetCandidatesByInternshipIdAsync(int internshipId, ReportType reportType)
		{
			CandidateStatusType? statusType = GetStatusType(reportType);

			var internship = await _context.Internships.AsNoTracking()
				.Include(x => x.Candidates.Where(r => r.StatusType == statusType || statusType == null))
				.Include(x => x.Users)
				.FirstOrDefaultAsync(x => x.Id == internshipId);

			return internship?.Candidates.ToList();
		}

		public async Task<int> GetCandidatesCountByTabelIdAsync(string tableId)
		{
			return await _context.Candidates.Where(x => x.Internship.SpreadSheetId == tableId).CountAsync();
		}

		public async Task<List<Candidate>> SearchCandidatesAsync(int skip, int take, string searchText, string sortBy, bool isDesc, int internshipId)
		{
			return await _context.Candidates
				.Include(x => x.Internship)
				.Where(x => x.FirstName.Contains(searchText) | x.LastName.Contains(searchText))
				.Where(x => x.InternshipId == internshipId)
				.Skip(skip)
				.Take(take)
				.OrderByPropertyName(sortBy, isDesc)
				.ToListAsync();
		}

		private CandidateStatusType? GetStatusType(ReportType reportType)
		{
			if (reportType == ReportType.CandidatesAccepted)
				return CandidateStatusType.Accepted;
			else if (reportType == ReportType.CandidatesRejection)
				return CandidateStatusType.Declined;
			else return null;
		}

		public IQueryable<Candidate> GetCandidatesForFIlter()
		{
			var candidates = _context.Candidates
				.Include(c => c.Internship)
				.Include(c => c.Users);

			return candidates;
		}

		public async Task<List<Candidate>> GetCandidatesListById(List<int> candidatesId)
		{
			return await _context.Candidates.Where(x => candidatesId.Contains(x.Id)).ToListAsync();
		}
	}
}