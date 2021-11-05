using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using System;
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

        public async Task<List<User>> GetMentorsByInternshipIdAsync(int id)
        {
            var internship = await _context.Internships.AsNoTracking().Include(x => x.Users).FirstOrDefaultAsync(x => x.Id == id);

            var roles = _context.Users.Where(x => x.RoleType == RoleType.Mentor).Select(x => x.Id);

            var mentors = internship?.Users.Where(x => roles.Contains(x.Id)).ToList();          

            return mentors;
        }
    }
}
