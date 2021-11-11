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

        private ICandidateRepository _canidateRepository;
        private IInternshipRepository _internshipRepository;
        private IUserRepository _userRepository;
        private IFeedbackRepository _feedbackRepository;
        private IEvaluationRepository _evaluationRepository;
        private ISkillRepository _skillRepository;
        private IBestContactTimeRepository _bestContactTimeRepository;
        private ILocationRepository _locationRepository;

        public ILocationRepository Locations
        {
            get
            {
                if (_locationRepository == null)
                    _locationRepository = new LocationRepository(_db);
                return _locationRepository;
            }
        }

        public IBestContactTimeRepository BestContactTime
        {
            get
            {
                if (_bestContactTimeRepository == null)
                    _bestContactTimeRepository = new BestContactTimeRepository(_db);
                return _bestContactTimeRepository;
            }
        }

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
                    _userRepository = new UserRepository(_db);
                return _userRepository;
            }
        }
        public IFeedbackRepository Feedbacks
        {
            get
            {
                if (_feedbackRepository == null)
                    _feedbackRepository = new FeedbackRepository(_db);
                return _feedbackRepository;
            }
        }

        public IEvaluationRepository Evaluations
        {
            get
            {
                if (_evaluationRepository == null)
                    _evaluationRepository = new EvaluationRepository(_db);
                return _evaluationRepository;
            }
        }

        public ISkillRepository Skills
        {
            get
            {
                if (_skillRepository == null)
                    _skillRepository = new SkillRepository(_db);
                return _skillRepository;
            }
        }

        public EFUnitOfWork(ApplicationDbContext db, UserManager<User> userManager)
        {
            _db = db;
        }

        public EFUnitOfWork(ApplicationDbContext db)
        {
            _db = db;
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
