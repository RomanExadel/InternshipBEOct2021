using AutoMapper;
using DAL.Interfaces;
using Moq;
using Xunit;
using System.Collections.Generic;
using Tests.Fixtures;
using BL.Interfaces;
using BL.EqualityComparers;
using BL.Services;
using BL.Mapping.Profiles;
using BL.DTOs;
using System.Linq;
using DAL.Entities;

namespace Tests.Services
{
    public class LocationServiceTest
    {
        private readonly Mock<IUnitOfWork> _uowMock;
        private readonly LocationFixture _locationFixture;
        private readonly ILocationService _locationService;
        private readonly IMapper _mapper;

        public LocationServiceTest()
        {
            _locationFixture = new LocationFixture();
            _uowMock = new Mock<IUnitOfWork>();
            _mapper = new MapperConfiguration(cfg => cfg.AddProfile(new CountryProfile())).CreateMapper();
            _locationService = new LocationService(_mapper, _uowMock.Object);
        }

        [Fact]
        public async void GetAllLocations_InvokeMethod_GettingLocations()
        {
            //Arrange
            var locations = _locationFixture.GetCountries();
            var expectedLocations = _mapper.Map<List<CountryDTO>>(locations);

            //Act
            _uowMock.Setup(x => x.Locations.GetAllAsync()).ReturnsAsync(locations);
            var actual = await _locationService.GetLocationsAsync();

            //Assert
            Assert.Equal(expectedLocations, actual, new LocationDTOEqualityComparer());
        }

        [Fact]
        public async void GetAllLocationsNames_InvokeMethod_GettingLocationsNames()
        {
            //Arrange
            var locationsNames = _locationFixture.GetCountries().Select(x => x.Name).Distinct().ToList();
            var expectedLocations = _mapper.Map<List<string>>(locationsNames);

            //Act
            _uowMock.Setup(x => x.Locations.GetLocationNamesAsync()).ReturnsAsync(locationsNames);
            var actual = await _locationService.GetLocationNamesAsync();

            //Assert
            Assert.Equal(expectedLocations, actual);
        }

        [Fact]
        public async void CreateLocation_WhenLocationNameIsCorrect_GetUpdatedLocationsList()
        {
            //Arrange
            var inputLocation = new Country { Id = 0, Name = "Name" };
            var outputLocation = new Country { Id = 5, Name = "Name" };
            var inputLocationDTO = _mapper.Map<CountryDTO>(inputLocation);
            var expectedLocationDTO = _mapper.Map<CountryDTO>(outputLocation);
            _uowMock.Setup(x => x.Locations.CreateLocationAsync(It.IsAny<string>()))
                .ReturnsAsync(outputLocation);

            //Act
            var actualLocationDTO = await _locationService.CreateLocationAsync(inputLocationDTO);

            //Assert
            Assert.Equal(expectedLocationDTO, actualLocationDTO, new LocationDTOEqualityComparer());
        }
    }
}
