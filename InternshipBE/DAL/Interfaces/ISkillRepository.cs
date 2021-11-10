using DAL.Entities;
using Shared.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ISkillRepository : IGenericRepository<Skill>
    {
        Task<List<Skill>> GetSkillsByStackTypeAsync(StackType stackType);
    }
}
