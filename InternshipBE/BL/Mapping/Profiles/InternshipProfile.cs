using AutoMapper;
using BL.DTOs;
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
                .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.CandidatesCount, src => src.MapFrom(entity => entity.Candidates.Count))
                .ForMember(dto => dto.DeclinedCandidatesCount, src => src.MapFrom(entity => entity.Candidates.Where(x => x.StatusType == CandidateStatusType.Declined).Count()))
                .ForMember(dto => dto.AcceptedCandidatesCount, src => src.MapFrom(entity => entity.Candidates.Where(x => x.StatusType == CandidateStatusType.Accepted).Count()))
                .ForMember(dto => dto.AbandonedCandidatesCount, src => src.MapFrom(entity => entity.Candidates.Where(x => x.StatusType == CandidateStatusType.Abandoned).Count()))
                .ForMember(dto => dto.SuccessfullyFinishedCandidatesCount, src => src.MapFrom(entity => entity.Candidates.Where(x => x.StatusType == CandidateStatusType.SuccessfullyСompleted).Count()))
                .ForMember(dto => dto.TeamsCount, src => src.MapFrom(entity => entity.Teams.Count))
                .ForMember(dto => dto.Name, src => src.MapFrom(entity => entity.Name))
                .ForMember(dto => dto.StartDate, src => src.MapFrom(entity => entity.StartDate))
                .ForMember(dto => dto.EndDate, src => src.MapFrom(entity => entity.EndDate))
                .ForMember(dto => dto.Requirements, src => src.MapFrom(entity => entity.Requirements))
                .ForMember(dto => dto.MaxCandidateCount, src => src.MapFrom(entity => entity.MaxCandidateCount))
                .ForMember(dto => dto.RegistrationStartDate, src => src.MapFrom(entity => entity.RegistrationStartDate))
                .ForMember(dto => dto.RegistrationFinishDate, src => src.MapFrom(entity => entity.RegistrationFinishDate))
                .ForMember(dto => dto.LanguageTypes, src => src.MapFrom(entity => entity.LanguageTypes))
                .ForMember(dto => dto.InternshipStatusType, src => src.MapFrom(entity => entity.InternshipStatusType.ToString()))
                .ForMember(dto => dto.ImageLink, src => src.MapFrom(entity => entity.ImageLink))
                .ForMember(dto => dto.InternshipStacks, src => src.MapFrom(entity => entity.InternshipStacks))
                .ForMember(dto => dto.Locations, src => src.MapFrom(entity => entity.Countries))
                .ForMember(dto => dto.Users, src => src.MapFrom(entity => entity.Users));

            CreateMap<InternshipDTO, Internship>()
                .ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id))
                .ForMember(entity => entity.Name, src => src.MapFrom(dto => dto.Name))
                .ForMember(entity => entity.StartDate, src => src.MapFrom(dto => dto.StartDate))
                .ForMember(entity => entity.EndDate, src => src.MapFrom(dto => dto.EndDate))
                .ForMember(entity => entity.Requirements, src => src.MapFrom(dto => dto.Requirements))
                .ForMember(entity => entity.MaxCandidateCount, src => src.MapFrom(dto => dto.MaxCandidateCount))
                .ForMember(entity => entity.RegistrationStartDate, src => src.MapFrom(dto => dto.RegistrationStartDate))
                .ForMember(entity => entity.RegistrationFinishDate, src => src.MapFrom(dto => dto.RegistrationFinishDate))
                .ForMember(entity => entity.Candidates, o => o.Ignore())
                .ForMember(entity => entity.LanguageTypes, src => src.MapFrom(dto => dto.LanguageTypes))
                .ForMember(entity => entity.InternshipStacks, src => src.MapFrom(dto => dto.InternshipStacks))
                .ForMember(entity => entity.Users, src => src.MapFrom(dto => dto.Users))
                .ForMember(entity => entity.Teams, src => src.MapFrom(dto => dto.Teams))
                .ForMember(entity => entity.Countries, src => src.MapFrom(dto => dto.Locations))
                .ForMember(entity => entity.InternshipStatusType, src => src.MapFrom(dto => Enum.Parse<InternshipStatusType>(dto.InternshipStatusType)))
                .ForMember(entity => entity.ImageLink, src => src.MapFrom(dto => dto.ImageLink))
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}
