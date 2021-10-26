using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class InternshipRepository : GenericRepository<Internship>, IInternshipRepository
    {
        public InternshipRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
