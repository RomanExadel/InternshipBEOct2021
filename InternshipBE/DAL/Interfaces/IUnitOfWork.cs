using System;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		IBestContactTimeRepository BestContactTime { get; }

		ICandidateRepository Candidates { get; }

		IInternshipRepository Internships { get; }

        IFeedbackRepository Feedbacks { get; }

        IEvaluationRepository Evaluations { get; }

        ISkillRepository Skills { get; }

        IInternshipStackRepository InternshipStacks { get; }

        IUserRepository Users { get; }

        ILocationRepository Locations { get; }

        Task SaveAsync();
    }
}
