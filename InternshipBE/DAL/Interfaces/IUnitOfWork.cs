using System;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICandidateRepository Candidates { get; }

        IInternshipRepository Internships { get; }

        IInternshipStackRepository InternshipStacks { get; }

        Task SaveAsync();
    }
}
