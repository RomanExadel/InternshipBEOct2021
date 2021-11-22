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
                .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.TechnologyStackType, src => src.MapFrom(entity => entity.TechnologyStackType.ToString()))
                .ForMember(dto => dto.InternshipId, src => src.MapFrom(entity => entity.InternshipId));

            CreateMap<InternshipStackDTO, InternshipStack>()
                .ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id))
                .ForMember(entity => entity.TechnologyStackType, src => src.MapFrom(dto => Enum.Parse<StackType>(dto.TechnologyStackType)))
                .ForMember(entity => entity.InternshipId, src => src.MapFrom(dto => dto.InternshipId));
        }
    }
}
