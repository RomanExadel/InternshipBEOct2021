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
                .ForMember(entity => entity.Id, src => src.MapFrom(dto => dto.Id))
                .ForMember(entity => entity.Position, src => src.MapFrom(dto => dto.Position))
                .ForMember(entity => entity.Email, src => src.MapFrom(dto => dto.Email))
                .ForMember(entity => entity.PhoneNumber, src => src.MapFrom(dto => dto.PhoneNumber))
                .ForMember(entity => entity.UserName, src => src.MapFrom(dto => dto.UserName))
                .ForMember(entity => entity.RoleType, src => src.MapFrom(dto => dto.RoleType.ToString()));

            CreateMap<UserDTO, User>()
                .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
                .ForMember(dto => dto.Position, src => src.MapFrom(entity => entity.Position))
                .ForMember(dto => dto.Email, src => src.MapFrom(entity => entity.Email))
                .ForMember(dto => dto.PhoneNumber, src => src.MapFrom(entity => entity.PhoneNumber))
                .ForMember(dto => dto.UserName, src => src.MapFrom(entity => entity.UserName))
                .ForMember(dto => dto.RoleType, src => src.MapFrom(entity => Enum.Parse<RoleType>(entity.RoleType)));

        }
    }
}
