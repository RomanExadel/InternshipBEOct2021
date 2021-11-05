using AutoMapper;
using BL.DTOs;
using DAL.Entities;
using Shared.Enums;
using System.Linq;

namespace BL.Mapping.Profiles
{
    public class InternshipProfile : Profile
    {
        public InternshipProfile()
        {
            CreateMap<Internship, InternshipDTO>()
                .ForMember(dto => dto.InternshipStackTypes, src => src.MapFrom(entity => entity.InternshipStacks.Select(x => x.TechnologyStackType)))
                .ForMember(dto => dto.LocationIds, src => src.MapFrom(entity => entity.Countries.Select(x => x.Id)))
                .ForMember(dto => dto.CandidatesCount, src => src.MapFrom(entity => entity.Candidates.Count))
                .ForMember(dto => dto.SuccessfullyFinishedCandidatesCount, src => src.MapFrom(entity => entity.Candidates.Where(x => x.StatusType == CandidateStatusType.SuccessfullyСompleted).Count()))
                .ForMember(dto => dto.DeclinedCandidatesCount, src => src.MapFrom(entity => entity.Candidates.Where(x => x.StatusType == CandidateStatusType.Declined).Count()))
                .ForMember(dto => dto.AcceptedCandidatesCount, src => src.MapFrom(entity => entity.Candidates.Where(x => x.StatusType == CandidateStatusType.Accepted).Count()))
                .ForMember(dto => dto.AbandonedCandidatesCount, src => src.MapFrom(entity => entity.Candidates.Where(x => x.StatusType == CandidateStatusType.Abandoned).Count()))
                .ForMember(dto => dto.TeamsCount, src => src.MapFrom(entity => entity.Teams.Count))
                .ReverseMap();
        }
    }
}
