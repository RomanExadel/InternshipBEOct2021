using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
