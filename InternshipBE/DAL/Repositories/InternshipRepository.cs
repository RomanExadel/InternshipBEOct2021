using DAL.Database;
using DAL.Entities;
using DAL.Entities.Filtering;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class InternshipRepository : GenericRepository<Internship>, IInternshipRepository
    {
        public InternshipRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<Internship> GetByIdAsync(int id)
        {
            return await _context.Internships.AsNoTracking()
                                             .Include(x => x.InternshipStacks)
                                             .Include(x => x.Countries)
                                             .Include(x => x.Candidates)
                                             .Include(x => x.Teams)
                                             .Include(x => x.Users)
                                             .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Internship>> GetInternshipsAsync(int pageSize, int pageNumber)
        {
            return await _context.Internships.AsNoTracking()
                                             .Include(x => x.InternshipStacks)
                                             .Include(x => x.Countries)
                                             .Include(x => x.Candidates)
                                             .Include(x => x.Teams)
                                             .Include(x => x.Users)
                                             .Skip(pageSize * --pageNumber)
                                             .Take(pageSize)
                                             .ToListAsync();
        }

        public async Task<List<Internship>> GetFilteredInternshipsAsync(IntershipFilterModel filterBy, int pageSize, int pageNumber)
        {
            var internships = await _context.Internships.ToListAsync();

            if (filterBy.Location != null)
                internships = internships.Where(i => i.Countries.Any(c => c.Name == filterBy.Location)).ToList(); 
            if (filterBy.LanguageTypes != null)
                foreach (var language in filterBy.LanguageTypes)
                {
                    internships = internships.Where(i => i.LanguageTypes.Any(l => l.LanguageType == language)).ToList();
                }
            if (filterBy.InternshipStacks != null)
                foreach(var stack in filterBy.InternshipStacks)
                {
                    internships = internships.Where(i => i.InternshipStacks.Any(s => s.TechnologyStackType == stack)).ToList();
                }
            if (filterBy.AttachedUsers != null)
                foreach (var userName in filterBy.AttachedUsers)
                {
                    internships = internships.Where(i => i.Users.Any(u => u.UserName == userName)).ToList();
                }
            if(filterBy.IntershipYear.HasValue)
                internships = internships.Where(i => i.StartDate.Year == filterBy.IntershipYear).ToList();

            return internships.Skip(pageSize * --pageNumber)
                                                .Take(pageSize).ToList();
        }
    }
}
