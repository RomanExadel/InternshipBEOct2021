using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class InternshipLanguageRepository : GenericRepository<InternshipLanguage>, IInternshipLanguageRepository
    {
        public InternshipLanguageRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Internship> CreateOrDeleteLanguagesAsync(Internship oldInternship, Internship newInternship)
        {
            if (newInternship.LanguageTypes.Count >= oldInternship.LanguageTypes.Count)
            {
                _context.InternshipLanguages.RemoveRange(oldInternship.LanguageTypes);

                oldInternship.LanguageTypes = newInternship.LanguageTypes.Except(await _context.InternshipLanguages.ToListAsync()).ToList();

                await _context.InternshipLanguages.AddRangeAsync(oldInternship.LanguageTypes);
            }

            if (newInternship.LanguageTypes.Count < oldInternship.LanguageTypes.Count)
            {
                _context.InternshipLanguages.RemoveRange(oldInternship.LanguageTypes);
                await _context.InternshipLanguages.AddRangeAsync(newInternship.LanguageTypes);
            }

            return newInternship;
        }
    }
}
