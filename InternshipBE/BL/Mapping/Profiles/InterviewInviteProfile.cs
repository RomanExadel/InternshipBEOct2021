using AutoMapper;
using BL.DTOs;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
    public class InterviewInviteProfile : Profile
    {
        public InterviewInviteProfile()
        {
            CreateMap<InterviewInvite, InterviewInviteDTO>()
                .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.Candidate, src => src.MapFrom(entity => entity.Candidate))
                .ForMember(dto => dto.CandidateId, src => src.MapFrom(entity => entity.CandidateId))
                .ForMember(dto => dto.ContactDate, src => src.MapFrom(entity => entity.ContactDate))
                .ForMember(dto => dto.User, src => src.MapFrom(entity => entity.User))
                .ForMember(dto => dto.UserId, src => src.MapFrom(entity => entity.UserId));

            CreateMap<InterviewInviteDTO, InterviewInvite>()
                .ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id))
                .ForMember(entity => entity.Candidate, src => src.MapFrom(dto => dto.Candidate))
                .ForMember(entity => entity.CandidateId, src => src.MapFrom(dto => dto.CandidateId))
                .ForMember(entity => entity.ContactDate, src => src.MapFrom(dto => dto.ContactDate))
                .ForMember(entity => entity.User, src => src.MapFrom(dto => dto.User))
                .ForMember(entity => entity.UserId, src => src.MapFrom(dto => dto.UserId));
        }
    }
}
