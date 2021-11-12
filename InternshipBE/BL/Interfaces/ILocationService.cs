using BL.DTOs.CountryDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ILocationService
    {
        Task<List<GetCountryDTO>> GetLocationsAsync();

        Task<GetCountryDTO> CreateLocationAsync(CountryDTO NameLocation);
    }
}
