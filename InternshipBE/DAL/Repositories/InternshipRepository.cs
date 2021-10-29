using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
<<<<<<< HEAD
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
=======
>>>>>>> 955ab32 (Delete Useless DTO, Fixed Problems)
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> 0915da6 (Changes in InternshipRepository)
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
<<<<<<< HEAD
<<<<<<< HEAD
            return await _context.Internships.Skip(itemsCount * pageNumber).Take(itemsCount).ToListAsync();
=======
            var internships = _context.Internships.ToList().Skip(itemsCount * pageNumber).Take(itemsCount).ToList();
            return await Task.FromResult(internships);
>>>>>>> 955ab32 (Delete Useless DTO, Fixed Problems)
=======
            return await _context.Internships.Skip(itemsCount * pageNumber).Take(itemsCount).ToListAsync();
>>>>>>> 0915da6 (Changes in InternshipRepository)
        }
    }
}
