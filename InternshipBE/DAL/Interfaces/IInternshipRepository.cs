using DAL.Entities;
using DAL.Entities.Filtering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IInternshipRepository : IGenericRepository<Internship>
    {
        Task<List<Internship>> GetInternshipsAsync(int pageSize, int pageNumber);

        Task<List<Internship>> GetFilteredInternshipsAsync(IntershipFilterModel filterBy, int pageSize, int pageNumber);
    }
}
