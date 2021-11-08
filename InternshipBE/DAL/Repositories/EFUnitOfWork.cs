using DAL.Database;
using DAL.Interfaces;
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
		private IBestContactTimeRepository _bestContactTimeRepository;

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
