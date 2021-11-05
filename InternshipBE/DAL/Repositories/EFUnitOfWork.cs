using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private bool _disposed;
        private ApplicationDbContext _db;
        private UserManager<User> _userManager;

        private ICandidateRepository _canidateRepository;
        private IInternshipRepository _internshipRepository;
        private IUserRepository _userRepository;

        public ICandidateRepository Candidates
        {
            get
            {
                if (_canidateRepository == null)
                    _canidateRepository = new CandidateRepository(_db);
                return _canidateRepository;
            }
        }

        public IInternshipRepository Internships
        {
            get
            {
                if (_internshipRepository == null)
                    _internshipRepository = new InternshipRepository(_db);
                return _internshipRepository;
            }
        }

        public IUserRepository Users
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_db, _userManager);
                return _userRepository;
            }
        }

        public EFUnitOfWork(ApplicationDbContext db, UserManager<User> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                this._disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
