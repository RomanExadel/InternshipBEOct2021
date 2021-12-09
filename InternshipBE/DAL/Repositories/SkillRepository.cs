using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SkillRepository : GenericRepository<Skill>, ISkillRepository
    {
        public SkillRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<Skill>> GetSkillsByStackTypeAsync(StackType stackType)
        {
            return await _context.Skills.AsNoTracking()
                                        .Where(x => x.StackType == stackType)
                                        .ToListAsync();
        }

        public async Task<List<Skill>> GetSkillsByStackTypesAsync(StackType[] stackTypes)
        {
            return await _context.Skills.AsNoTracking()
                                        .Where(x => stackTypes.Contains(x.StackType))
                                        .ToListAsync();
        }

        public async override Task<Skill> UpdateAsync(Skill entity)
        {
            var skill = await _context.Skills.FirstOrDefaultAsync(x => x.Id == entity.Id);

            skill.IsHardSkill = entity.IsHardSkill;
            skill.Name = entity.Name;
            skill.StackType = entity.StackType;

            return await base.UpdateAsync(skill);
        }
    }
}
