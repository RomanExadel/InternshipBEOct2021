using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class InternshipRepository : GenericRepository<Internship>, IInternshipRepository
    {
        public InternshipRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<Internship>> GetAllInternshipsPartialAsync(int itemsCount, int pageNumber)
        {
            var internships = _context.Internships.ToList().Skip(itemsCount * pageNumber).Take(itemsCount).ToList();
            return await Task.FromResult(internships);
        }
    }
}
