using AutoMapper;
using BL.DTOs;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, TeamDTO>()
                .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.InternshipId, src => src.MapFrom(entity => entity.InternshipId))
                .ForMember(dto => dto.Name, src => src.MapFrom(entity => entity.Name));

            CreateMap<TeamDTO, Team>()
                .ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id))
                .ForMember(entity => entity.InternshipId, src => src.MapFrom(dto => dto.InternshipId))
                .ForMember(entity => entity.Name, src => src.MapFrom(dto => dto.Name));
        }
    }
}
