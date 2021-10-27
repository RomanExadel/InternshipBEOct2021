using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
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
            return await Task.Run(() => _context.Internships.FirstOrDefault(x => x.Id == id)?.Candidate
                                                            .Skip(itemsCount * pageNumber)
                                                            .Take(itemsCount)
                                                            .ToList());
        }
    }
}