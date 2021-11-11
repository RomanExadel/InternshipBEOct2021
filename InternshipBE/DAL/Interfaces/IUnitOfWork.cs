using System;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICandidateRepository Candidates { get; }

        IInternshipRepository Internships { get; }

        IFeedbackRepository Feedbacks { get; }

        IEvaluationRepository Evaluations { get; }

        ISkillRepository Skills { get; }

        IInternshipStackRepository InternshipStacks { get; }

        IUserRepository Users { get; }

        Task SaveAsync();
    }
}
