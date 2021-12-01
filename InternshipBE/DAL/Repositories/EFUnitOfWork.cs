using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using System;

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
        private IInternshipStackRepository _internshipStackRepository;
        private ILocationRepository _locationRepository;
        private IInterviewInviteRepository _interviewInviteRepository;
        private ITeamRepository _teamRepository;
        private IInternshipLanguageRepository _internshipLanguageRepository;

        private IValidator<Candidate> _candidateValidator;
        private IValidator<Feedback> _feedbackValidator;
        private IValidator<Internship> _internshipValidator;
        private IValidator<Evaluation> _evaluationValidator;
        private IValidator<InterviewInvite> _interviewInviteValidator;
        private IValidator<Team> _teamValidator;

        public IInternshipLanguageRepository InternshipLanguages 
        {
            get 
            {
                if (_internshipLanguageRepository == null)
                    _internshipLanguageRepository = new InternshipLanguageRepository(_db);
                return _internshipLanguageRepository;
            }
        } 

        public ITeamRepository Teams 
        {
            get 
            {
                if (_teamRepository == null)
                    _teamRepository = new TeamRepository(_db, _teamValidator);
                return _teamRepository;
            }
        }

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
                    _canidateRepository = new CandidateRepository(_db, _candidateValidator);
                return _canidateRepository;
            }
        }

        public IInternshipRepository Internships
        {
            get
            {
                if (_internshipRepository == null)
                    _internshipRepository = new InternshipRepository(_db, _internshipValidator);
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
                    _feedbackRepository = new FeedbackRepository(_db, _feedbackValidator);
                return _feedbackRepository;
            }
        }

        public IEvaluationRepository Evaluations
        {
            get
            {
                if (_evaluationRepository == null)
                    _evaluationRepository = new EvaluationRepository(_db, _evaluationValidator);
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

        public IInternshipStackRepository InternshipStacks
        {
            get
            {
                if (_internshipStackRepository == null)
                    _internshipStackRepository = new InternshipStackRepository(_db);
                return _internshipStackRepository;
            }
        }

        public IInterviewInviteRepository InterviewInvites
        {
            get
            {
                if (_interviewInviteRepository == null)
                    _interviewInviteRepository = new InterviewInviteRepository(_db, _interviewInviteValidator);
                return _interviewInviteRepository;
            }
        }

        public EFUnitOfWork(ApplicationDbContext db, IValidator<Candidate> candidateValidator,
            IValidator<Feedback> feedbackValidator, IValidator<Internship> internshipValidator,
            IValidator<Evaluation> evaluationValidator, IValidator<InterviewInvite> interviewInviteValidator,
            IValidator<Team> teamValidator)
        {
            _db = db;
            _candidateValidator = candidateValidator;
            _feedbackValidator = feedbackValidator;
            _internshipValidator = internshipValidator;
            _evaluationValidator = evaluationValidator;
            _interviewInviteValidator = interviewInviteValidator;
            _teamValidator = teamValidator;
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
