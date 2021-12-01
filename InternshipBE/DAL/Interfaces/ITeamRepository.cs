using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ITeamRepository : IGenericRepository<Team>
    {
        Task<List<Team>> GetTeamsByInternshipIdAsync(int internshipId);
        Task<Internship> CreateOrDeleteTeamsAsync(Internship oldInternship, Internship newInternship);
    }
}
