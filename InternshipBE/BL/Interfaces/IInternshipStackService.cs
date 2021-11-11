using BL.DTOs.InternshipStackDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IInternshipStackService
    {
        Task<List<GetInternshipStackDTO>> GetInternshipStacksByInternshipIdAsync(int internshipId);

        Task<FullInternshipStackDTO> CreateInternshipStackAsync(CreateInternshipStackDTO internshipStackDto);

        Task<FullInternshipStackDTO> UpdateInternshipStackAsync(FullInternshipStackDTO internshipStackDto);
    }
}
