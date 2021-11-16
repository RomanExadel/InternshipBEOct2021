using AutoMapper;
using BL.DTOs;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
    public class EvaluationProfile : Profile
    {
        public EvaluationProfile()
        {
            CreateMap<Evaluation, EvaluationDTO>()
                .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.SkillId, src => src.MapFrom(entity => entity.SkillId))
                .ForMember(dto => dto.FeedbackId, src => src.MapFrom(entity => entity.FeedbackId))
                .ForMember(dto => dto.Value, src => src.MapFrom(entity => entity.Value))
                .ForMember(dto => dto.Skill, src => src.MapFrom(entity => entity.Skill))
                .ReverseMap()
                .ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id))
                .ForMember(entity => entity.SkillId, src => src.MapFrom(dto => dto.SkillId))
                .ForMember(entity => entity.FeedbackId, src => src.MapFrom(dto => dto.FeedbackId))
                .ForMember(entity => entity.Value, src => src.MapFrom(dto => dto.Value))
                .ForMember(entity => entity.Skill, o => o.Ignore())
                .ForMember(entity => entity.Feedback, o => o.Ignore());
        }
    }
}