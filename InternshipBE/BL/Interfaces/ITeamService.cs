using BL.DTOs;
using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ITeamService
    {
        Task<List<TeamDTO>> GetTeamsByInternshipIdAsync(int internshipId);

        Task<TeamDTO> CreateTeamByInternshipIdAsync(TeamDTO team);

        Task<Internship> CreateOrDeleteTeamsAsync(Internship oldInternship, Internship newInternship);
    }
}
