using BL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ITeamService
    {
        Task<List<TeamDTO>> GetTeamsByInternshipIdAsync(int internshipId);

        Task<TeamDTO> CreateTeamByInternshipIdAsync(TeamDTO team);
    }
}
