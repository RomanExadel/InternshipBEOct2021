using AutoMapper;
using BL.DTOs.CountryDTOs;
using BL.Interfaces;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class LocationService : ILocationService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public LocationService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<GetCountryDTO>> GetLocationsAsync()
        {
            var locations = await _unitOfWork.Locations.GetLocationsAsync();

            return _mapper.Map<List<GetCountryDTO>>(locations);
        }

        public async Task<GetCountryDTO> CreateLocationAsync(CountryDTO locationName)
        {
            var result = await _unitOfWork.Locations.CreateLocationAsync(locationName.Name);

            return _mapper.Map<CountryDTO>(result);
        }
    }
}
