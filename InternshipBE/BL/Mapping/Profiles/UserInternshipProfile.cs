using AutoMapper;
using BL.DTOs;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
    public class UserInternshipProfile: Profile
    {
        public UserInternshipProfile()
        {
            CreateMap<UserInternship, UserInternshipDTO>().ReverseMap();
        }
    }
}
