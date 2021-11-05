using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<User> _userManager;

        public UserRepository(ApplicationDbContext context, UserManager<User> userManager) : base(context)
        {
            _userManager = userManager;
        }

        public async Task<List<User>> GetUsersByInternshipIdAsync(int id)
        {
            var internship = await _context.Internships.Include(x => x.Users).FirstOrDefaultAsync(x => x.Id == id);
            var users = internship?.Users.ToList();
            var mentors = await GetMentorsAsync(users);

            return mentors;
        }

        private async Task<List<User>> GetMentorsAsync(List<User> users)
        {
            var mentors = new List<User>();

            if (users == null)
                throw new ArgumentNullException(nameof(users), "users is null");

            foreach (var user in users)
            {
                var role = await GetUserRoleAsync(user);

                if (role == RoleType.Hr.ToString())
                {
                    mentors.Add(user);
                }
            }

            return mentors;
        }

        public async Task<string> GetUserRoleAsync(User user)
        {
            var roles = await _userManager.GetRolesAsync(user);

            if (roles == null)
            {
                throw new ArgumentNullException(nameof(roles), "roles is null");
            }

            return roles.Single();
        }
    }
}
