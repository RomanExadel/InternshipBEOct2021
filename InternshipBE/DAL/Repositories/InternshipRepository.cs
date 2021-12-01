using DAL.Database;
using DAL.Entities;
using DAL.Entities.Filtering;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;
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

        public async Task<List<Internship>> GetInternshipsAsync(int pageSize, int pageNumber, InternshipFilterModel filterBy)
        {
            if (filterBy != null)
            {
                return GetFilteredInternshipsAsync(pageSize, pageNumber, filterBy).ToList();
            }
            else
            {
                return await _context.Internships.AsNoTracking()
                 .Include(x => x.InternshipStacks)
                 .Include(x => x.LanguageTypes)
                 .Include(x => x.Countries)
                 .Include(x => x.Candidates)
                 .Include(x => x.Teams)
                 .Include(x => x.Users)
                 .Skip(pageSize * --pageNumber)
                 .Take(pageSize)
                 .ToListAsync();
            }

        }

        private IQueryable<Internship> GetFilteredInternshipsAsync(int pageSize, int pageNumber, InternshipFilterModel filterBy)
        {
            var internships = _context.Internships
                 .Include(x => x.InternshipStacks)
                 .Include(x => x.LanguageTypes)
                 .Include(x => x.Countries)
                 .Include(x => x.Candidates)
                 .Include(x => x.Teams)
                 .Include(x => x.Users).AsEnumerable();

            if (filterBy.Locations != null)
                foreach(var internship in internships)
                    internships = internships.Where(i => filterBy.Locations.Any(x => i.Countries.Any(c => c.Name == x)));
            if (filterBy.LanguageTypes != null)
                foreach (var internship in internships)
                    internships = internships.Where(i => filterBy.LanguageTypes.Any(x => i.LanguageTypes.Any(l => l.LanguageType == (InternshipLanguageType)Enum.Parse(typeof(InternshipLanguageType), x))));
            if (filterBy.InternshipStatusType != null)
                foreach (var internship in internships)
                    internships = internships.Where(i => filterBy.InternshipStatusType == Enum.GetName(typeof(InternshipStatusType), i.InternshipStatusType));
            if (filterBy.InternshipStacks != null)
                foreach (var internship in internships)
                    internships = internships.Where(i => filterBy.InternshipStacks.Any(x => i.InternshipStacks.Any(l => l.TechnologyStackType == (StackType)Enum.Parse(typeof(StackType), x))));
            if(filterBy.IntershipYear != 0)
                internships = internships.Where(i => i.StartDate.Year == filterBy.IntershipYear);
            if (filterBy.AttachedUsers != null)
                foreach (var internship in internships)
                    internships = internships.Where(i => filterBy.AttachedUsers.Any(u => i.Users.Any(x => x.UserName == u)));

            return internships.AsQueryable().AsNoTracking();
        }
    }
}
