using AutoMapper;
using BL.DTOs;
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
                .ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id))
                .ForMember(entity => entity.TechnologyStackType, src => src.MapFrom(dto => dto.TechnologyStackType.ToString()));

            CreateMap<InternshipStackDTO, InternshipStack>()
                .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.TechnologyStackType, src => src.MapFrom(entity => Enum.Parse<StackType>(entity.TechnologyStackType)))
                .ForMember(dto => dto.InternshipId, o => o.Ignore());
        }
    }
}
