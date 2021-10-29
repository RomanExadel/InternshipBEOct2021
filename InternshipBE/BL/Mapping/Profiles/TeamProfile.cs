using AutoMapper;
using BL.DTOs;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, TeamDTO>().ReverseMap();
        }
    }
}
