using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
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

        public async Task<List<string>> GetLocationNamesAsync()
        {
            return await _unitOfWork.Locations.GetLocationNamesAsync();
        }

        public async Task<List<CountryDTO>> GetLocationsAsync()
        {
            var locations = await _unitOfWork.Locations.GetAllAsync();
            
            return _mapper.Map<List<CountryDTO>>(locations);
        }

        public async Task<CountryDTO> CreateLocationAsync(CountryDTO locationName)
        {
            var result = await _unitOfWork.Locations.CreateLocationAsync(locationName.Name);

            return _mapper.Map<CountryDTO>(result);
        }

        public async Task<Internship> CreateOrDeleteLocationsAsync(Internship oldInternship, Internship newInternship)
        {
            return await _unitOfWork.Locations.CreateOrDeleteLocationsAsync(oldInternship, newInternship);
        }
    }
}
