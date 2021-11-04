using AutoMapper;
using BL.DTOs;
using DAL.Entities;
using System.Linq;

namespace BL.Mapping.Profiles
{
    public class InternshipProfile : Profile
    {
        public InternshipProfile()
        {
            CreateMap<Internship, InternshipDTO>()
                .ForMember(dto => dto.InternshipStackTypes, src => src.MapFrom(entity => entity.InternshipStacks.Select(x => x.TechnologyStackType)))
                .ReverseMap();
        }
    }
}
