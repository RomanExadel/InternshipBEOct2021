using AutoMapper;
using BL.DTOs.InternshipStackDTOs;
using DAL.Entities;
using Shared.Enums;
using System;

namespace BL.Mapping.Profiles
{
    public class InternshipStackProfile : Profile
    {
        public InternshipStackProfile()
        {
            CreateMap<InternshipStack, InternshipStackDTO>()
                .ForMember(dto => dto.TechnologyStackType, src => src.MapFrom(entity => entity.TechnologyStackType.ToString()))
                .ReverseMap()
                .ForMember(entity => entity.TechnologyStackType, src => src.MapFrom(dto => Enum.Parse<StackType>(dto.TechnologyStackType)));

            CreateMap<InternshipStack, GetInternshipStackDTO>()
                .ForMember(dto => dto.TechnologyStackType, src => src.MapFrom(entity => entity.TechnologyStackType.ToString()))
                .ReverseMap()
                .ForMember(entity => entity.TechnologyStackType, src => src.MapFrom(dto => Enum.Parse<StackType>(dto.TechnologyStackType)));

            CreateMap<InternshipStack, CreateInternshipStackDTO>()
                .ForMember(dto => dto.TechnologyStackType, src => src.MapFrom(entity => entity.TechnologyStackType.ToString()))
                .ReverseMap()
                .ForMember(entity => entity.TechnologyStackType, src => src.MapFrom(dto => Enum.Parse<StackType>(dto.TechnologyStackType)));

            CreateMap<InternshipStack, FullInternshipStackDTO>()
                .ForMember(dto => dto.TechnologyStackType, src => src.MapFrom(entity => entity.TechnologyStackType.ToString()))
                .ForMember(dto => dto.FeedbackId, src => src.MapFrom(entity => entity.InternshipId))
                .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
                .ReverseMap()
                .ForMember(entity => entity.TechnologyStackType, src => src.MapFrom(dto => Enum.Parse<StackType>(dto.TechnologyStackType)))
                .ForMember(entity => entity.InternshipId, src => src.MapFrom(dto => dto.FeedbackId))
                .ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id));
        }
    }
}
