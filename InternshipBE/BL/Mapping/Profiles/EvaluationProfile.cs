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
                .ForMember(dto => dto.SkillId, src => src.MapFrom(entity => entity.Skill.Id))
                .ForMember(dto => dto.FeedbackId, src => src.MapFrom(entity => entity.Feedback.Id))
                .ReverseMap();
        }
    }
}