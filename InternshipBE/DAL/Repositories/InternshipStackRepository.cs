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

        public Task<List<InternshipStack>> GetInternshipStacksByInternshipIdAsync(int id)
        {
            return _context.InternshipStacks.Where(x => x.InternshipId == id).ToListAsync();
        }
    }
}
