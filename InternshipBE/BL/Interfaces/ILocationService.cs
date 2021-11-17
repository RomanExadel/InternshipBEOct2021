using BL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ILocationService
    {
        Task<List<CountryDTO>> GetLocationsAsync();

        Task<CountryDTO> CreateLocationAsync(CountryDTO NameLocation);
    }
}
