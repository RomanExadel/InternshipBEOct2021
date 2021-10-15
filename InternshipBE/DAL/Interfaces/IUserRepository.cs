using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
	public interface IUserRepository : IDisposable
	{
		public void Create(User user, string password);

		public Task<User> GetAsync(string login);

		public List<User> GetAll();

		public void Update(User user);

		public void Delete(Guid token);

	}
}
