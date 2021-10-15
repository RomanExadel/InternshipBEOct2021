using BL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
	public interface IUserService : IDisposable
	{
		Task<string> Authenticate(string login, string password);
	}
}
