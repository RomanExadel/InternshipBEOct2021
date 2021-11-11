using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
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
	}
}