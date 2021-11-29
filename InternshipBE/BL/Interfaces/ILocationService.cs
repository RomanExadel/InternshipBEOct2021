using BL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ILocationService
    {
        Task<List<string>> GetLocationsAsync();

        Task<CountryDTO> CreateLocationAsync(CountryDTO NameLocation);
    }
}
