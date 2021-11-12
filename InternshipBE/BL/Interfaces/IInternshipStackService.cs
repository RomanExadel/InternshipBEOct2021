using BL.DTOs.InternshipStackDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IInternshipStackService
    {
        Task<List<GetInternshipStackDTO>> GetInternshipStacksAsync();

        Task<List<GetInternshipStackDTO>> GetInternshipStacksByInternshipIdAsync(int internshipId);

        Task<GetInternshipStackDTO> CreateInternshipStackAsync(InternshipStackDTO internshipStackDto);

        Task<GetInternshipStackDTO> UpdateInternshipStackAsync(GetInternshipStackDTO internshipStackDto);
    }
}
