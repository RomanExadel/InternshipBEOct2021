using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class EvaluationRepository : GenericRepository<Evaluation>, IEvaluationRepository
    {
        public EvaluationRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
