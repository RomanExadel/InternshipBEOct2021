using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class LocationRepository : GenericRepository<Country>, ILocationRepository
    {
        public LocationRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<string>> GetLocationNamesAsync()
        {
            return await _context.Countries.Select(x => x.Name).Distinct().ToListAsync();
        }

        public async Task<Country> CreateLocationAsync(string NameLocation)
        {
            var location = new Country { Name = NameLocation };

            return await CreateAsync(location);
        }

        public async Task<Internship> CreateOrDeleteLocationsAsync(Internship oldInternship, Internship newInternship)
        {
            if (newInternship.Countries.Count >= oldInternship.Countries.Count)
            {
                _context.Countries.RemoveRange(oldInternship.Countries);

                oldInternship.Countries = newInternship.Countries.Except(await _context.Countries.ToListAsync()).ToList();

                await _context.Countries.AddRangeAsync(oldInternship.Countries);
            }

            if (newInternship.Countries.Count < oldInternship.Countries.Count)
            {
                _context.Countries.RemoveRange(oldInternship.Countries);
                await _context.Countries.AddRangeAsync(newInternship.Countries);
            }

            return newInternship;
        }
    }
}
