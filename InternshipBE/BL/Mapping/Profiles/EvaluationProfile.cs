using AutoMapper;
using BL.DTOs;
using BL.DTOs.EvaluationDTOs;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
    public class EvaluationProfile : Profile
    {
        public EvaluationProfile()
        {
            CreateMap<Evaluation, EvaluationDTO>()
                .ForMember(dto => dto.SkillName, src => src.MapFrom(entity => entity.Skill.Name))
                .ReverseMap()
                .ForMember(entity => entity.Id, o => o.Ignore())
                .ForMember(entity => entity.FeedbackId, o => o.Ignore());

            CreateMap<Evaluation, GetEvaluationDTO>()
                .ForMember(dto => dto.SkillName, src => src.MapFrom(entity => entity.Skill.Name))
                .ReverseMap()
                .ForMember(entity => entity.FeedbackId, o => o.Ignore());

            CreateMap<Evaluation, CreateEvaluationDTO>()
                .ForMember(dto => dto.SkillName, src => src.MapFrom(entity => entity.Skill.Name))
                .ReverseMap()
                .ForMember(entity => entity.Id, o => o.Ignore());

            CreateMap<Evaluation, FullEvaluationDTO>()
                .ForMember(dto => dto.SkillName, src => src.MapFrom(entity => entity.Skill.Name))
                .ReverseMap();
        }
    }
}
