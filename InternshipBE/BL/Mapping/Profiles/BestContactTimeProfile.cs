using AutoMapper;
using BL.DTOs.BestContactTimeDTO;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
	public class BestContactTimeProfile : Profile
	{
		public BestContactTimeProfile()
		{
			CreateMap<BestContactTime, BestContactTimeDTO>()
				 .ForMember(dto => dto.Id, src => src.MapFrom(entity => entity.Id))
				 .ForMember(dto => dto.StartTime, src => src.MapFrom(entity => entity.StartTime))
				 .ForMember(dto => dto.EndTime, src => src.MapFrom(entity => entity.EndTime))
				 .ForMember(dto => dto.User, src => src.MapFrom(entity => entity.User))
				 .ReverseMap();

			CreateMap<CreateBestContactTimeDTO, BestContactTime>()
				 .ForMember(entity => entity.StartTime, src => src.MapFrom(dto => dto.StartTime))
				 .ForMember(entity => entity.EndTime, src => src.MapFrom(dto => dto.EndTime))
				 .ReverseMap();

			CreateMap<EventDTO, BestContactTime>()
				 .ForMember(dto => dto.StartTime, src => src.MapFrom(entity => entity.StartTime))
				 .ForMember(dto => dto.EndTime, src => src.MapFrom(entity => entity.EndTime))
				 .ReverseMap();

		}
	}
}
