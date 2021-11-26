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
        private readonly IValidator<Internship> _validator;

        public InternshipRepository(ApplicationDbContext context, IValidator<Internship> validator) : base(context)
        {
            _validator = validator;
        }

        public override async Task<Internship> GetByIdAsync(int id)
        {
            var internship = await _context.Internships.AsNoTracking()
                                            .Include(x => x.InternshipStacks)
                                            .Include(x => x.Countries)
                                            .Include(x => x.Candidates)
                                            .Include(x => x.Teams)
                                            .Include(x => x.Users)
                                            .Include(x => x.LanguageTypes)
                                            .FirstOrDefaultAsync(x => x.Id == id);

            _validator.ValidateIfEntityExist(internship);

            return internship;
        }

        public override async Task<Internship> UpdateAsync(Internship newInternship)
        {
            var internship = await _context.Internships
                .Include(x => x.Teams)
                .Include(x => x.Users)
                .Include(x => x.Candidates)
                .Include(x => x.Countries)
                .Include(x => x.InternshipStacks)
                .FirstOrDefaultAsync(x => x.Id == newInternship.Id);

            _validator.ValidateIfEntityExist(internship);

            internship.Name = newInternship.Name;
            internship.StartDate = newInternship.StartDate;
            internship.EndDate = newInternship.EndDate;
            internship.Requirements = newInternship.Requirements;
            internship.MaxCandidateCount = newInternship.MaxCandidateCount;
            internship.RegistrationFinishDate = newInternship.RegistrationFinishDate;
            internship.RegistrationStartDate = newInternship.RegistrationStartDate;
            internship.Candidates = await _context.Candidates.Where(x => x.InternshipId == newInternship.Id).ToListAsync();
            internship.LanguageTypes = newInternship.LanguageTypes;
            internship.InternshipStacks = await _context.InternshipStacks.Where(x => x.InternshipId == newInternship.Id).ToListAsync();
            internship.Users = await _context.Users.Where(x => newInternship.Users.Contains(x)).ToListAsync();
            internship.Teams = await _context.Teams.Where(x => x.InternshipId == newInternship.Id).ToListAsync();
            internship.Countries = await _context.Countries.Where(x => newInternship.Countries.Contains(x)).ToListAsync();
            internship.InternshipStatusType = newInternship.InternshipStatusType;
            internship.ImageLink = newInternship.ImageLink;

            _context.Internships.Update(internship);

            await _context.SaveChangesAsync();

            return internship;
        }

        public async Task<List<Internship>> GetInternshipsAsync(int pageSize, int pageNumber, InternshipFilterModel filterBy)
        {
            if (filterBy != null)
            {
                return GetFilteredInternshipsAsync(pageSize, pageNumber, filterBy);
            }
            else
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

        }

        private List<Internship> GetFilteredInternshipsAsync(int pageSize, int pageNumber, InternshipFilterModel filterBy)
        {
            var internships = _context.Internships.AsQueryable();

            if (filterBy.Locations != null)
                foreach (var location in filterBy.Locations)
                {
                    internships = internships.Where(i => i.Countries.Any(l => l.Name == location));
                }
            if (filterBy.LanguageTypes != null)
                foreach (var language in filterBy.LanguageTypes)
                {
                    internships = internships.Where(i => i.LanguageTypes.Any(l => l.LanguageType == language));
                }
            if (filterBy.InternshipStacks != null)
                foreach (var stack in filterBy.InternshipStacks)
                {
                    internships = internships.Where(i => i.InternshipStacks.Any(s => s.TechnologyStackType == stack));
                }
            if (filterBy.AttachedUsers != null)
                foreach (var userName in filterBy.AttachedUsers)
                {
                    internships = internships.Where(i => i.Users.Any(u => u.UserName.Contains(userName)));
                }
            if (filterBy.IntershipYear.HasValue)
                internships = internships.Where(i => i.StartDate.Year == filterBy.IntershipYear);

            return internships.AsNoTracking()
                                    .Include(x => x.InternshipStacks)
                                    .Include(x => x.Countries)
                                    .Include(x => x.Candidates)
                                    .Include(x => x.Teams)
                                    .Include(x => x.Users)
                                    .Skip(pageSize * --pageNumber)
                                    .Take(pageSize)
                                    .ToList();
        }
    }
}
