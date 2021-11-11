using AutoMapper;
using BL.DTOs.InternshipDTOs;
using DAL.Entities;
using Shared.Enums;
using System;
using System.Linq;

namespace BL.Mapping.Profiles
{
    public class InternshipProfile : Profile
    {
        public InternshipProfile()
        {
            CreateMap<Internship, InternshipDTO>()
                .ForMember(dto => dto.InternshipStatusType, src => src.MapFrom(entity => entity.InternshipStatusType.ToString()))
                .ForMember(dto => dto.LanguageType, src => src.MapFrom(entity => entity.LanguageType.ToString()))
                .ForMember(dto => dto.Locations, src => src.MapFrom(entity => entity.Countries))
                .ReverseMap()
                .ForMember(entity => entity.InternshipStatusType, src => src.MapFrom(dto => Enum.Parse<InternshipStatusType>(dto.InternshipStatusType)))
                .ForMember(entity => entity.LanguageType, src => src.MapFrom(dto => Enum.Parse<LanguageType>(dto.LanguageType)));
            
            CreateMap<Internship, GetInternshipDTO>()
                .ForMember(dto => dto.InternshipStatusType, src => src.MapFrom(entity => entity.InternshipStatusType.ToString()))
                .ForMember(dto => dto.LanguageType, src => src.MapFrom(entity => entity.LanguageType.ToString()))
                .ForMember(dto => dto.Locations, src => src.MapFrom(entity => entity.Countries))
                .ForMember(dto => dto.CandidatesCount, src => src.MapFrom(entity => entity.Candidates.Count))
                .ForMember(dto => dto.SuccessfullyFinishedCandidatesCount, src => src.MapFrom(entity => entity.Candidates.Where(x => x.StatusType == CandidateStatusType.SuccessfullyСompleted).Count()))
                .ForMember(dto => dto.DeclinedCandidatesCount, src => src.MapFrom(entity => entity.Candidates.Where(x => x.StatusType == CandidateStatusType.Declined).Count()))
                .ForMember(dto => dto.AcceptedCandidatesCount, src => src.MapFrom(entity => entity.Candidates.Where(x => x.StatusType == CandidateStatusType.Accepted).Count()))
                .ForMember(dto => dto.AbandonedCandidatesCount, src => src.MapFrom(entity => entity.Candidates.Where(x => x.StatusType == CandidateStatusType.Abandoned).Count()))
                .ForMember(dto => dto.TeamsCount, src => src.MapFrom(entity => entity.Teams.Count))
                .ReverseMap()
                .ForMember(entity => entity.InternshipStatusType, src => src.MapFrom(dto => Enum.Parse<InternshipStatusType>(dto.InternshipStatusType)))
                .ForMember(entity => entity.LanguageType, src => src.MapFrom(dto => Enum.Parse<LanguageType>(dto.LanguageType)));

            CreateMap<Internship, CreateInternshipDTO>()
                .ForMember(dto => dto.InternshipStatusType, src => src.MapFrom(entity => entity.InternshipStatusType.ToString()))
                .ForMember(dto => dto.LanguageType, src => src.MapFrom(entity => entity.LanguageType.ToString()))
                .ForMember(dto => dto.Locations, src => src.MapFrom(entity => entity.Countries))
                .ReverseMap()
                .ForMember(entity => entity.InternshipStatusType, src => src.MapFrom(dto => Enum.Parse<InternshipStatusType>(dto.InternshipStatusType)))
                .ForMember(entity => entity.LanguageType, src => src.MapFrom(dto => Enum.Parse<LanguageType>(dto.LanguageType)));
            
            CreateMap<Internship, UpdateInternshipDTO>()
                .ForMember(dto => dto.InternshipStatusType, src => src.MapFrom(entity => entity.InternshipStatusType.ToString()))
                .ForMember(dto => dto.LanguageType, src => src.MapFrom(entity => entity.LanguageType.ToString()))
                .ForMember(dto => dto.Locations, src => src.MapFrom(entity => entity.Countries))
                .ReverseMap()
                .ForMember(entity => entity.InternshipStatusType, src => src.MapFrom(dto => Enum.Parse<InternshipStatusType>(dto.InternshipStatusType)))
                .ForMember(entity => entity.LanguageType, src => src.MapFrom(dto => Enum.Parse<LanguageType>(dto.LanguageType)));
        }
    }
}
