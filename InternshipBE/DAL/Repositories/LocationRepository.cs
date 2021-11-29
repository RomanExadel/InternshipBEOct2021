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

        public async Task<List<string>> GetLocationsAsync()
        {
            return await _context.Countries.Select(x => x.Name).Distinct().ToListAsync();
        }

        public async Task<Country> CreateLocationAsync(string NameLocation)
        {
            var location = new Country { Name = NameLocation };

            return await CreateAsync(location);
        }
    }
}
