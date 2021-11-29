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
