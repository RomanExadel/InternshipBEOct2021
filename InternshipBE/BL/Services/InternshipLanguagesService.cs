using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System.Threading.Tasks;

namespace BL.Services
{
    public class InternshipLanguagesService : IInternshipLanguagesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public InternshipLanguagesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Internship> CreateOrDeleteLanguages(Internship oldInternship, Internship newInternship)
        {
            return await _unitOfWork.InternshipLanguages.CreateOrDeleteLanguagesAsync(oldInternship, newInternship);
        }
    }
}
