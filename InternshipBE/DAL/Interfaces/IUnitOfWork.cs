using System;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICandidateRepository Candidates { get; }

        IInternshipRepository Internships { get; }
    }
}
