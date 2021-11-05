using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> GetMentorsByInternshipIdAsync(int id);
    }
}
