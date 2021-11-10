using DAL.Entities;
using Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> GetSpecificUsersByInternshipIdAsync(int id, RoleType? roleType);

        Task<List<User>> GetUsersByCandidateIdAsync(int id);

        Task<List<User>> UpdateUsersFromInternshipAsync(int id, string[] usersId);
    }
}
