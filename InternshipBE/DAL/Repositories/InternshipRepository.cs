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

        public async Task<List<Internship>> GetInternshipsAsync(int itemsCount, int pageNumber)
        {
            return await _context.Internships.Skip(itemsCount * --pageNumber).Take(itemsCount).ToListAsync();
        }
    }
}
