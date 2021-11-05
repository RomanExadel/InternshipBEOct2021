using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> GetUsersByInternshipIdAsync(int id);

        Task<string> GetUserRoleAsync(User user);
    }
}
