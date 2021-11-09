using AutoMapper;
using BL.DTOs.FeedbackDTOs;
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
                .ForMember(dto => dto.EnglishLevelType, src => src.MapFrom(entity => entity.EnglishLevelType.ToString()))
                .ReverseMap()
                .ForMember(entity => entity.EnglishLevelType, src => src.MapFrom(dto => Enum.Parse<EnglishLevelType>(dto.EnglishLevelType)))
                .ForMember(entity => entity.Id, o => o.Ignore());

            CreateMap<Feedback, GetFeedbackDTO>()
                .ForMember(dto => dto.EnglishLevelType, src => src.MapFrom(entity => entity.EnglishLevelType.ToString()))
                .ForMember(dto => dto.CandidateFirstName, src => src.MapFrom(entity => entity.Candidate.FirstName))
                .ForMember(dto => dto.CandidateLastName, src => src.MapFrom(entity => entity.Candidate.LastName))
                .ReverseMap()
                .ForMember(entity => entity.EnglishLevelType, src => src.MapFrom(dto => Enum.Parse<EnglishLevelType>(dto.EnglishLevelType)))
                .ForMember(entity => entity.Id, o => o.Ignore());

            CreateMap<Feedback, UpdateFeedbackDTO>()
                .ForMember(dto => dto.EnglishLevelType, src => src.MapFrom(entity => entity.EnglishLevelType.ToString()))
                .ReverseMap()
                .ForMember(entity => entity.EnglishLevelType, src => src.MapFrom(dto => Enum.Parse<EnglishLevelType>(dto.EnglishLevelType)));

            CreateMap<Feedback, FullFeedbackDTO>()
                .ForMember(dto => dto.EnglishLevelType, src => src.MapFrom(entity => entity.EnglishLevelType.ToString()))
                .ForMember(dto => dto.CandidateFirstName, src => src.MapFrom(entity => entity.Candidate.FirstName))
                .ForMember(dto => dto.CandidateLastName, src => src.MapFrom(entity => entity.Candidate.LastName))
                .ReverseMap()
                .ForMember(entity => entity.EnglishLevelType, src => src.MapFrom(dto => Enum.Parse<EnglishLevelType>(dto.EnglishLevelType)));
        }
    }
}
