using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
	public class UserRepository : GenericRepository<User>, IUserRepository
	{ 
		public UserRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
