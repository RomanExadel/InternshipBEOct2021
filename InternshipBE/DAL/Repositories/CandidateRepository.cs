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

        public async Task<List<Candidate>> GetAllByInternshipIdAsync(int id, int itemsCount, int pageNumber)
        {
            var internship = await _context.Internships.Include(x => x.Candidate).FirstOrDefaultAsync(x => x.Id == id);

            return internship?.Candidate.Skip(itemsCount * --pageNumber).Take(itemsCount).ToList();
        }
    }
}