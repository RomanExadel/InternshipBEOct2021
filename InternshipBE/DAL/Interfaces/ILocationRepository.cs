using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ILocationRepository : IGenericRepository<Country>
    {
        Task<List<Country>> GetLocationsAsync();

        Task<Country> CreateLocationAsync(string NameLocation);
    }
}
