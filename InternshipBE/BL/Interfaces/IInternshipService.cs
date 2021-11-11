using BL.DTOs.InternshipDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IInternshipService
    {
        Task<GetInternshipDTO> GetInternshipByIdAsync(int id);

        Task<UpdateInternshipDTO> CreateInternshipAsync(CreateInternshipDTO newInternship);

        Task<UpdateInternshipDTO> UpdateInternshipAsync(UpdateInternshipDTO updatedInternship);

        Task<List<GetInternshipDTO>> GetInternshipsAsync(int pageSize, int pageNumber);
    }
}
