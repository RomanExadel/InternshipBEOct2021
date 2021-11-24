using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public override async Task<Internship> GetByIdAsync(int id)
        {
            return await _context.Internships.AsNoTracking()
                                             .Include(x => x.InternshipStacks)
                                             .Include(x => x.Countries)
                                             .Include(x => x.Candidates)
                                             .Include(x => x.Teams)
                                             .Include(x => x.Users)
                                             .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Internship>> GetInternshipsAsync(int pageSize, int pageNumber)
        {
            return await _context.Internships.AsNoTracking()
                                             .Include(x => x.InternshipStacks)
                                             .Include(x => x.Countries)
                                             .Include(x => x.Candidates)
                                             .Include(x => x.Teams)
                                             .Include(x => x.Users)
                                             .Skip(pageSize * --pageNumber)
                                             .Take(pageSize)
                                             .ToListAsync();
        }
    }
}
