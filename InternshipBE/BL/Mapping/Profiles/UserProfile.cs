using AutoMapper;
using BL.DTOs.UserDTOs;
using DAL.Entities;
using Shared.Enums;
using System;

namespace BL.Mapping.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
                .ForMember(dto => dto.RoleType, src => src.MapFrom(entity => entity.RoleType.ToString()))
                .ReverseMap()
                .ForMember(entity => entity.RoleType, src => src.MapFrom(dto => Enum.Parse<RoleType>(dto.RoleType)));
        }
    }
}
