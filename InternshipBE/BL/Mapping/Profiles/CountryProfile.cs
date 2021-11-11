using AutoMapper;
using BL.DTOs.CountryDTOs;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, GetCountryDTO>().ReverseMap();
        }
    }
}
