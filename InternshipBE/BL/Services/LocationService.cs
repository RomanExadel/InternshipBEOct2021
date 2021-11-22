using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Interfaces;
using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class LocationService : ILocationService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AbstractValidator<CountryDTO> _validations;

        public LocationService(IMapper mapper, IUnitOfWork unitOfWork, AbstractValidator<CountryDTO> validations)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _validations = validations;
        }

        public async Task<List<CountryDTO>> GetLocationsAsync()
        {
            var locations = await _unitOfWork.Locations.GetLocationsAsync();

            return _mapper.Map<List<CountryDTO>>(locations);
        }

        public async Task<CountryDTO> CreateLocationAsync(CountryDTO locationName)
        {
            await _validations.ValidateAndThrowAsync(locationName);

            var result = await _unitOfWork.Locations.CreateLocationAsync(locationName.Name);

            return _mapper.Map<CountryDTO>(result);
        }
    }
}
