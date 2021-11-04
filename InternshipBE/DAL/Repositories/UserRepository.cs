using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
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

		public async Task<List<User>> GetUsersByInternshipIdAsync(int id)
		{
			var internship = await _context.Internships.Include(x => x.Users).FirstOrDefaultAsync(x => x.Id == id);

			return internship?.Users.ToList();
		}
	}
}
