using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
	public class BestContactTimeService : IBestContactTimeService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly UserManager<User> _userManager;

		public BestContactTimeService(IUnitOfWork unitOfWork, IMapper mapper, UserManager<User> userManager)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_userManager = userManager;
		}

		public async Task<List<BestContactTimeDTO>> GetAllBestTimeByIdAsync(string interviewerId)
		{
			var timeList = await _unitOfWork.BestContactTime.GetAllByUserIdAsync(interviewerId);

			return _mapper.Map<List<BestContactTimeDTO>>(timeList);
		}

		public async Task SaveBestContactTimeAsync(string userName, List<BestContactTimeDTO> models)
		{
			var user = await _userManager.FindByNameAsync(userName);

			var bestContactTime = _mapper.Map<List<BestContactTime>>(models);
			bestContactTime.ForEach(x => x.User = user);

			await _unitOfWork.BestContactTime.RangeSaveAsync(bestContactTime);
		}
	}
}
