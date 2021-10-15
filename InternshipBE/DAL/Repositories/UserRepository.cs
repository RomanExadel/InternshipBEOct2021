using DAL.Database;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class UserRepository : IUserRepository
	{
		private UserManager<User> _userManager; 

		public UserRepository(UserManager<User> userManager)
		{
			_userManager = userManager;
		}

		public void Create(User user, string password)
		{
			throw new NotImplementedException();
		}

		public void Delete(Guid token)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public async Task<User> GetAsync(string login)
		{
			var user = await _userManager.FindByNameAsync(login);

			return user;
		}

		public List<User> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Update(User user)
		{
			throw new NotImplementedException();
		}
	}
}
