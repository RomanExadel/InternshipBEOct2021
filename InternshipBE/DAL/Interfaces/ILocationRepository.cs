using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ILocationRepository : IGenericRepository<Country>
    {
        Task<List<string>> GetLocationNamesAsync();

        Task<Country> CreateLocationAsync(string NameLocation);
    }
}
