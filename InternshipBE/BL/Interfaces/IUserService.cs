using BL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IUserService
    {
        Task<string> AuthenticateAsync(string email, string password);

        Task<UserDTO> GetUserInfoByUserNameAsync(string userName);

        Task<List<UserDTO>> GetMentorsByInternshipId(int id);
    }
}
