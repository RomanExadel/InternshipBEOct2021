using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    interface ILocationRepository: IGenericRepository<Country>
    {
        Task<List<Country>> GetLocationsAsync();
    }
}
