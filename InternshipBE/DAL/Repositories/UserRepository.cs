using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
	{ 
		public UserRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}
