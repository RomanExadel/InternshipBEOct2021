using BL.DTOs;
using BL.DTOs.SkillDTOs;
using Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ISkillService
    {
        Task<SkillDTO> CreateSkillAsync(SkillDTO skillDto);

        Task<FullSkillDTO> UpdateSkillAsync(FullSkillDTO fullSkillDto);

        Task<List<FullSkillDTO>> GetSkillsByStackTypeAsync(StackType stackType);
    }
}
