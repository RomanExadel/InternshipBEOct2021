using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IInternshipStackRepository : IGenericRepository<InternshipStack>
    {
        Task<List<InternshipStack>> GetAllByInternshipIdAsync(int internshipId);
        
        Task<List<InternshipStack>> CreateRangeAsync(ICollection<InternshipStack> internshipStacks);
    }
}
