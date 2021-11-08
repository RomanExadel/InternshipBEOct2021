using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IBestContactTimeRepository : IGenericRepository<BestContactTime>
    {
        Task<List<BestContactTime>> GetAllByUserIdAsync(string userId);
    }
}