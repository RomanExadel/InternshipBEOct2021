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

        public async Task<List<CountryDTO>> GetLocationsAsync()
        {
            var locations = await _unitOfWork.Locations.GetLocationsAsync();

            return _mapper.Map<List<CountryDTO>>(locations);
        }

        public async Task<CountryDTO> CreateLocationAsync(CountryDTO locationName)
        {
            var result = await _unitOfWork.Locations.CreateLocationAsync(locationName.Name);

            await _unitOfWork.SaveAsync();

            return _mapper.Map<CountryDTO>(result);
        }
    }
}
