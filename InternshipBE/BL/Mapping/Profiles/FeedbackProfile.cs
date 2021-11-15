using AutoMapper;
using BL.DTOs;
using DAL.Entities;
using Shared.Enums;
using System;

namespace BL.Mapping.Profiles
{
    public class FeedbackProfile: Profile
    {
        public FeedbackProfile()
        {
            CreateMap<Feedback, FeedbackDTO>()
                .ForMember(dto => dto.EnglishLevelName, src => src.MapFrom(entity => entity.EnglishLevelType.ToString()))
                .ReverseMap()
                .ForMember(entity => entity.EnglishLevelType, src => src.MapFrom(dto => Enum.Parse<EnglishLevelType>(dto.EnglishLevelName)))
                .ForMember(entity => entity.Id, o => o.Ignore());
        }
    }
}
