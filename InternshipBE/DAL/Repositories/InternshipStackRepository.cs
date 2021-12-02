using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class InternshipStackRepository : GenericRepository<InternshipStack>, IInternshipStackRepository
    {
        public InternshipStackRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Internship> CreateOrDeleteStacksAsync(Internship oldInternship, Internship newInternship)
        {
            if (newInternship.InternshipStacks.Count >= oldInternship.InternshipStacks.Count)
            {
                _context.InternshipStacks.RemoveRange(oldInternship.InternshipStacks);

                oldInternship.InternshipStacks = newInternship.InternshipStacks.Except(await _context.InternshipStacks.ToListAsync()).ToList();

                await _context.InternshipStacks.AddRangeAsync(oldInternship.InternshipStacks);
            }

            if (newInternship.InternshipStacks.Count < oldInternship.InternshipStacks.Count)
            {
                _context.InternshipStacks.RemoveRange(oldInternship.InternshipStacks);
                await _context.InternshipStacks.AddRangeAsync(newInternship.InternshipStacks);
            }

            return newInternship;
        }

        public async Task<List<InternshipStack>> CreateRangeAsync(ICollection<InternshipStack> internshipStacks)
        {
            var newIntershipStacks = new List<InternshipStack>();

            foreach (var internshipStack in internshipStacks)
            {
                if (await _context.InternshipStacks.AnyAsync(x => x.TechnologyStackType == internshipStack.TechnologyStackType))
                {
                    newIntershipStacks.Add(await _context.InternshipStacks.FirstOrDefaultAsync(x => x.TechnologyStackType == internshipStack.TechnologyStackType));
                }
                else
                {
                    newIntershipStacks.Add(await CreateAsync(internshipStack));
                }
            }

            return newIntershipStacks;
        }

        public async Task<List<InternshipStack>> GetAllByInternshipIdAsync(int internshipId)
        {
            var internship = await _context.Internships.AsNoTracking()
                                            .Include(x => x.InternshipStacks)
                                            .FirstOrDefaultAsync(x => x.Id == internshipId);

            return internship?.InternshipStacks.ToList();
        }
    }
}