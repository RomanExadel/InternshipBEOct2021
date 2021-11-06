using System;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICandidateRepository Candidates { get; }

        IInternshipRepository Internships { get; }

        IFeedbackRepository Feedbacks { get; }

        IUserRepository Users { get; }

        Task SaveAsync();
    }
}
