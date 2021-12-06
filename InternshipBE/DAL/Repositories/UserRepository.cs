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

		public async Task<List<User>> UpdateUsersFromInternshipAsync(int id, string[] usersId, UpdateUserType updateType)
		{
			var users = await _context.Users.Include(x => x.Internships.Where(i => i.Id == id))
				.Where(x => usersId.Contains(x.Id))
				.ToListAsync();

			if (updateType == UpdateUserType.Delete)
			{
				users.ForEach(x => x.Internships.Clear());
			}
            else 
			{
				var internship = await _context.Internships.FirstAsync(x => x.Id == id);

				users.ForEach(x => x.Internships.Add(internship));
			}			

			await _context.SaveChangesAsync();

			return users;
		}

		public async Task<User> GetUserInfoById(string id)
		{
			var user = await _context.Users
				.AsNoTracking()
				.FirstOrDefaultAsync(u => u.Id == id);
			
			return user;
		}

	}
}
