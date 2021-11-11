using DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface ICandidateRepository : IGenericRepository<Candidate>
	{
		Task<List<Candidate>> GetCandidatesByInternshipIdAsync(int id, int pageSize, int pageNumber);

		Task<int> GetCandidatesCountAsync();

		IQueryable<Candidate> GetAllCandidates();
	}
}
