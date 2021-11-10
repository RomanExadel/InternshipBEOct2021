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
        }
    }
}
