using AutoMapper;
using BL.DTOs.SkillDTOs;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
    public class SkillProfile : Profile
    {
        public SkillProfile()
        {
            CreateMap<Skill, SkillDTO>()
                .ForMember(dto => dto.StackType, src => src.MapFrom(entity => entity.StackType.ToString()))
                .ReverseMap();
        }
    }
}
