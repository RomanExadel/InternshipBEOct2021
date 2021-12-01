using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        private readonly IValidator<Team> _validator;
        public TeamRepository(ApplicationDbContext context, IValidator<Team> validator) : base(context)
        {
            _validator = validator;
        }

        public async Task<Internship> CreateOrDeleteTeamsAsync(Internship oldInternship, Internship newInternship)
        {
            if (newInternship.Teams.Count >= oldInternship.Teams.Count)
            {
                _context.Teams.RemoveRange(oldInternship.Teams);

                oldInternship.Teams = newInternship.Teams.Except(await _context.Teams.ToListAsync()).ToList();

                await _context.Teams.AddRangeAsync(oldInternship.Teams);
            }

            if (newInternship.Teams.Count < oldInternship.Teams.Count)
            {
                _context.Teams.RemoveRange(oldInternship.Teams);
                await _context.Teams.AddRangeAsync(newInternship.Teams);
            }

            return newInternship;
        }

        public async Task<List<Team>> GetTeamsByInternshipIdAsync(int internshipId)
        {
            var teams =  await _context.Teams.AsNoTracking()
                .Include(x => x.Internship)
                .Include(x => x.Users)
                .Where(x => x.InternshipId == internshipId)
                .ToListAsync();

            _validator.ValidateIfEntitesExist(teams);

            return teams;
        }
    }
}
