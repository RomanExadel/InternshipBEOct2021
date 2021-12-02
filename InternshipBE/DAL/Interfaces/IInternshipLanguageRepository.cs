using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IInternshipLanguageRepository : IGenericRepository<InternshipLanguage>
    {
        Task<Internship> CreateOrDeleteLanguagesAsync(Internship oldInternship, Internship newInternship);
    }
}
