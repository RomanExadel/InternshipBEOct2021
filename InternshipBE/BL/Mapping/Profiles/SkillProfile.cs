using AutoMapper;
using BL.DTOs;
using DAL.Entities;
using Shared.Enums;
using System;

namespace BL.Mapping.Profiles
{
    public class SkillProfile : Profile
    {
        public SkillProfile()
        {
            CreateMap<Skill, SkillDTO>()
                .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.StackType, src => src.MapFrom(entity => entity.StackType.ToString()))
                .ForMember(dto => dto.Name, src => src.MapFrom(entity => entity.Name))
                .ForMember(dto => dto.IsHardSkill, src => src.MapFrom(entity => entity.IsHardSkill));

            CreateMap<SkillDTO, Skill>()
                .ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id))
                .ForMember(entity => entity.StackType, src => src.MapFrom(dto => Enum.Parse<StackType>(dto.StackType)))
                .ForMember(entity => entity.Name, src => src.MapFrom(dto => dto.Name))
                .ForMember(entity => entity.IsHardSkill, src => src.MapFrom(dto => dto.IsHardSkill))
                .ForMember(entity => entity.Evaluations, o => o.Ignore());
        }
    }
}
