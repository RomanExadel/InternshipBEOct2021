using BL.DTOs;
using DAL.Entities.Filtering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IInternshipService
    {
        Task<InternshipDTO> GetInternshipByIdAsync(int id);

        Task<InternshipDTO> CreateInternshipAsync(InternshipDTO newInternship);

        Task<InternshipDTO> UpdateInternshipAsync(InternshipDTO updatedInternship);

        Task<List<InternshipDTO>> GetInternshipsAsync(int pageSize, int pageNumber, InternshipFilterModel<string> filterBy);
    }
}
