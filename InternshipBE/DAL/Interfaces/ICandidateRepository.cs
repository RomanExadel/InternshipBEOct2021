using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICandidateRepository : IGenericRepository<Candidate>
    {
        Task<List<Candidate>> GetAllByInternshipIdAsync(int id, int itemsCount, int pageNumber);
    }
}
