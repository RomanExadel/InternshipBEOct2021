using BL.DTOs;
using Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ISkillService
    {
        Task<SkillDTO> CreateSkillAsync(SkillDTO skillDto);

        Task<SkillDTO> UpdateSkillAsync(SkillDTO skillDto);

        Task<List<SkillDTO>> GetSkillsByStackTypeAsync(StackType stackType);
    }
}
