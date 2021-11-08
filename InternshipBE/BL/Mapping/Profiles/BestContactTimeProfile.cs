using AutoMapper;
using BL.DTOs;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
	public class BestContactTimeProfile : Profile
	{
		public BestContactTimeProfile()
		{
			CreateMap<BestContactTime, BestContactTimeDTO>();
			CreateMap<BestContactTimeDTO, BestContactTime>()
				.ForMember(x => x.Id, o => o.Ignore());
		}
	}
}
