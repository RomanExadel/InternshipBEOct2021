using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IInternshipStackRepository
    {
        Task<List<InternshipStack>> GetInternshipStacksByInternshipIdAsync(int id);
    }
}
