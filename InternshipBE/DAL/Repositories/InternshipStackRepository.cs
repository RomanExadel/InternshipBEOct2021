using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class InternshipStackRepository : GenericRepository<InternshipStack>, IInternshipStackRepository
    {
        public InternshipStackRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<InternshipStack>> GetAllByInternshipIdAsync(int internshipId)
        {
            return await _context.InternshipStacks.AsNoTracking()
                                                  .Include(x => x.Internship)
                                                  .Where(x => x.InternshipId == internshipId)
                                                  .ToListAsync();
        }
    }
}
