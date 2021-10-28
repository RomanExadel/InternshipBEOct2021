using BL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IInternshipService
    {
        Task<InternshipDTO> GetInternshipAsync(int id);

        Task<InternshipDTO> CreateInternshipAsync(InternshipDTO newInternship);

        Task<InternshipDTO> UpdateInternshipAsync(InternshipDTO newInternship);

<<<<<<< HEAD
        Task<List<InternshipDTO>> GetAllInternshipsPartialAsync(int itemsCount, int pageNumber);
=======
        Task<List<InternshipDTO>> GetAllInternshipAsync();
>>>>>>> 6b6dd06 (Implement Internship service and controller. Implement API for Create, Update, Get one and Get all internships.)
    }
}
