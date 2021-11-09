using System;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		IBestContactTimeRepository BestContactTime { get; }

		ICandidateRepository Candidates { get; }

		IInternshipRepository Internships { get; }

		IUserRepository Users { get; }

		Task SaveAsync();
	}
}
