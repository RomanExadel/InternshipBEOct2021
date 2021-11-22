using AutoMapper;
using BL.DTOs;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryDTO>()
                .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.Name, src => src.MapFrom(entity => entity.Name));

            CreateMap<CountryDTO, Country>()
                .ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id))
                .ForMember(entity => entity.Name, src => src.MapFrom(dto => dto.Name))
                .ForMember(entity => entity.Internships, o => o.Ignore());

            CreateMap<string, Country>()
                .ForMember(entity => entity.Name, src => src.MapFrom(x => x))
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
