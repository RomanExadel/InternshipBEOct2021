using AutoMapper;
using BL.DTOs;
using DAL.Entities;
using Shared.Enums;
using System;

namespace BL.Mapping.Profiles
{
    public class InternshipLanguageProfile : Profile
    {
        public InternshipLanguageProfile()
        {
            CreateMap<InternshipLanguage, InternshipLanguageDTO>()
                .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.Language, src => src.MapFrom(entity => entity.LanguageType.ToString()));

            CreateMap<InternshipLanguageDTO, InternshipLanguage>()
                .ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id))
                .ForMember(entity => entity.LanguageType, src => src.MapFrom(dto => Enum.Parse<InternshipLanguageType>(dto.Language)));
        }
    }
}
