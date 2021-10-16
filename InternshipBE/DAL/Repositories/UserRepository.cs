using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
	public class UserRepository : IRepository<User>
	{
		private UserManager<User> _userManager;

		public UserRepository(UserManager<User> userManager)
		{
			_userManager = userManager;
		}

		public void Create(User user)
		{
			throw new NotImplementedException();
		}

		public void Delete()
		{
			throw new NotImplementedException();
		}

		public async Task<User> GetAsync(object model)
		{
			string login = (string)model;

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
