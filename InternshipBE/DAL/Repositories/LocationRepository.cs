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

        public async Task<List<Country>> GetLocationsAsync()
        {
            return await GetAllAsync();
        }

        public async Task<Country> CreateLocationAsync(string NameLocation)
        {
            var location = new Country { Name = NameLocation };

            await CreateAsync(location);
            await _context.SaveChangesAsync();

            return location;
        }

        public async Task<List<string>> GetAllNamesAsync()
		{
            return await _context.Countries.Select(x => x.Name).ToListAsync();
		}
    }
}
