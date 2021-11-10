﻿using AutoMapper;
using BL.DTOs.BestContactTimeDTO;
using DAL.Entities;

namespace BL.Mapping.Profiles
{
	public class BestContactTimeProfile : Profile
	{
		public BestContactTimeProfile()
		{
			CreateMap<BestContactTime, BestContactTimeDTO>();
			CreateMap<BestContactTimeDTO, BestContactTime>();
			CreateMap<CreateBestContactTimeDTO, BestContactTime>();
			CreateMap<EventDTO, BestContactTime>();
		}
	}
}