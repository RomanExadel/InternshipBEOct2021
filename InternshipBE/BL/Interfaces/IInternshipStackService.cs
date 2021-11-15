using BL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IInternshipStackService
    {
        Task<List<InternshipStackDTO>> GetInternshipStacksAsync();

        Task<List<InternshipStackDTO>> GetInternshipStacksByInternshipIdAsync(int internshipId);

        Task<InternshipStackDTO> CreateInternshipStackAsync(InternshipStackDTO internshipStackDto);

        Task<InternshipStackDTO> UpdateInternshipStackAsync(InternshipStackDTO internshipStackDto);
    }
}
