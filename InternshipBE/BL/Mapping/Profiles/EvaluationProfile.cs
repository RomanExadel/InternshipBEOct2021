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
                .ReverseMap();
        }
    }
}
