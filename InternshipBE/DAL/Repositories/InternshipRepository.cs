using DAL.Database;
using DAL.Entities;
using DAL.Entities.Filtering;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
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
                .Include(x => x.LanguageTypes)
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
            internship.Users = await _context.Users.Where(x => newInternship.Users.Contains(x)).ToListAsync();
            internship.Countries = await _context.Countries.Where(x => newInternship.Countries.Contains(x)).ToListAsync();
            internship.InternshipStatusType = newInternship.InternshipStatusType;
            internship.ImageLink = newInternship.ImageLink;
            internship.SpreadSheetId = newInternship.SpreadSheetId;

            await base.UpdateAsync(internship);

            return internship;
        }

        public async override Task<Internship> CreateAsync(Internship internship)
        {
            internship.Countries = await _context.Countries.Where(x => internship.Countries.Select(x => x.Id).Contains(x.Id)).ToListAsync();
            internship.Users = await _context.Users.Where(x => internship.Users.Select(x => x.Id).Contains(x.Id)).ToListAsync();

            return await base.CreateAsync(internship);
        }

        public async Task<List<Internship>> GetInternshipsAsync(int pageSize, int pageNumber, InternshipFilterModel<int> filterBy)
        {
            var internships = _context.Internships
                 .Include(x => x.InternshipStacks)
                 .Include(x => x.LanguageTypes)
                 .Include(x => x.Countries)
                 .Include(x => x.Candidates)
                 .Include(x => x.Teams)
                 .Include(x => x.Users).AsQueryable();

            if (filterBy != null)
            {
                internships = GetFilteredInternshipsAsync(internships, filterBy).AsQueryable();
            }

            return await internships.ToListAsync();
        }

        private IQueryable<Internship> GetFilteredInternshipsAsync(IQueryable<Internship> internships, InternshipFilterModel<int> filterBy)
        {
            if (filterBy.Locations != null)
               internships = internships.Where(i => i.Countries.Any(x => filterBy.Locations.Any(l => l == x.Name)));
            if (filterBy.LanguageTypes != null)
               internships = internships.Where(i => i.LanguageTypes.Any(x => filterBy.LanguageTypes.Any(l => l == (int)x.LanguageType)));
            if (filterBy.InternshipStatusTypes != null)
                internships = internships.Where(i => filterBy.InternshipStatusTypes.Any(x => x == (int)i.InternshipStatusType));
            if (filterBy.InternshipStacks != null)
                internships = internships.Where(i => i.InternshipStacks.Any(x => filterBy.InternshipStacks.Any(l => l == (int)x.TechnologyStackType)));
            if (filterBy.InternshipYear != 0)
                internships = internships.Where(i => i.StartDate.Year == filterBy.InternshipYear);
            if (filterBy.AttachedUsers != null)
                internships = internships.Where(i => i.Users.Any(x => filterBy.AttachedUsers.Any(u => u == x.UserName)));

            return internships;
        }
    }
}
