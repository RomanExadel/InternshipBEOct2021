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

        Task<List<InternshipDTO>> GetAllInternshipAsync();
    }
}
