using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {

        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<User>> GetSpecificUsersByInternshipIdAsync(int id, RoleType? roleType = null)
        {
            var internship = await _context.Internships.AsNoTracking()
                                                       .Include(x => x.Users.Where(u => u.RoleType == roleType || roleType == null))
                                                       .FirstOrDefaultAsync(x => x.Id == id);

            return internship?.Users.ToList();
        }

        public async Task<List<User>> GetUsersByCandidateIdAsync(int id)
        {
            var candidat = await _context.Candidates.AsNoTracking()
                                                    .Include(x => x.Users)
                                                    .FirstOrDefaultAsync(x => x.Id == id);

            return candidat?.Users.ToList();
        }
    }
}
