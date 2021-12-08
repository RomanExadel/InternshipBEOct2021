using BL.DTOs;
using DAL.Entities;
using System.Collections.Generic;

namespace Tests.Fixtures
{
    public class LocationFixture
    {
        private readonly List<Country> _countries;

        public LocationFixture()
        {
            _countries = new List<Country>
            {
                new Country { Id = 1, Name = "Name"},
                new Country { Id = 2, Name = "Name"},
                new Country { Id = 3, Name = "Name"},
                new Country { Id = 4, Name = "Name"}
            };
        }

        public List<Country> GetCountries()
        {
            return _countries;
        }
    }
}
