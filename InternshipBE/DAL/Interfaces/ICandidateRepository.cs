using DAL.Entities;
using Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities.Filtering;

namespace DAL.Interfaces
{
    public interface ICandidateRepository : IGenericRepository<Candidate>
    {
        Task<List<Candidate>> GetCandidatesByInternshipIdAsync(int id, int pageSize, int pageNumber, CandidateFilterModel filterBy, string sortBy, bool asc);

        Task<List<Candidate>> GetCandidatesByInternshipIdAsync(int internshipId, ReportType reportType);

        Task<int> GetCandidatesCountByTabelIdAsync(string tableId);

        Task<List<Candidate>> SearchCandidatesAsync(int skip, int take, string searchText, string sortBy, bool isDesc, int internshipId);

        Task<List<Candidate>> GetCandidatesListByIdAsync(List<int> candidatesId);
    }
}
