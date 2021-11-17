using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services
{
    public class SkillService : ISkillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SkillService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<SkillDTO> CreateSkillAsync(SkillDTO skillDto)
        {
            var skill = _mapper.Map<Skill>(skillDto);

            skill = await _unitOfWork.Skills.CreateAsync(skill);
            skillDto = _mapper.Map<SkillDTO>(skill);

            return skillDto;
        }

        public async Task<List<SkillDTO>> GetSkillsByStackTypeAsync(StackType stackType)
        {
            var skills = await _unitOfWork.Skills.GetSkillsByStackTypeAsync(stackType);

            return _mapper.Map<List<SkillDTO>>(skills);
        }

        public async Task<SkillDTO> UpdateSkillAsync(SkillDTO skillDTO)
        {
            var skill = _mapper.Map<Skill>(skillDTO);

            skill = await _unitOfWork.Skills.UpdateAsync(skill);

            return _mapper.Map<SkillDTO>(skill);
        }
    }
}