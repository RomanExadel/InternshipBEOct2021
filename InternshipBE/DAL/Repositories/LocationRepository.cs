using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
            return await _context.Countries.ToListAsync();
        }

        public async Task<Country> CreateLocationAsync(string NameLocation)
        {
            var location = new Country { Name = NameLocation };

            await _context.Countries.AddAsync(location);

            await _context.SaveChangesAsync();

            return location;
        }
    }
}
