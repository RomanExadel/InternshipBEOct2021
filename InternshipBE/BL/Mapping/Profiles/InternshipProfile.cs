using AutoMapper;
using BL.DTOs;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
    public class InternshipProfile : Profile
    {
        public InternshipProfile()
        {
            CreateMap<Internship, InternshipDTO>().ReverseMap();
        }
    }
}
