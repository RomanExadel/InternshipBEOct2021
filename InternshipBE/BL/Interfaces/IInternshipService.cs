using BL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IInternshipService
    {
        Task<InternshipDTO> GetInternshipById(int internshipId);

        Task<InternshipDTO> CreateInternshipAsync(InternshipDTO newInternship);

        Task<InternshipDTO> UpdateInternshipAsync(InternshipDTO updatedInternship);

        Task<List<InternshipDTO>> GetInternshipsAsync(int pageSize, int pageNumber);
    }
}
