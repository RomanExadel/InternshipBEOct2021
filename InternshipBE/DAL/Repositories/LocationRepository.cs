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
        public LocationRepository(ApplicationDbContext context): base(context)
        {            
        }

        public async Task<List<Country>> GetLocationsAsync()
        {
            var locations = await _context.Countries.ToListAsync();
            
            

            return null;
        }
    }
}
