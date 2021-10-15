using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;
		private UserManager<User> _userManager;
		private readonly IConfiguration _configuration;

		public UserService(IUserRepository userRepository, UserManager<User> userManager, IConfiguration configuration)
		{
			_userRepository = userRepository;
			_userManager = userManager;
			_configuration = configuration;
		}

		public async Task<string> Authenticate(string login, string password)
		{
			var user = await _userRepository.GetAsync(login);

			if (user != null && await _userManager.CheckPasswordAsync(user, password))
			{
				var roles = await _userManager.GetRolesAsync(user);
				var authClaims = new List<Claim>
				{
					new Claim(ClaimTypes.Name, user.UserName),
					//new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid.ToString())
				};

				foreach(var role in roles)
				{
					authClaims.Add(new Claim(ClaimTypes.Role, role));
				}

				var authSigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
				var currentTime = DateTime.UtcNow;

				var token = new JwtSecurityToken(
				_configuration["Jwt:Issuer"],
				_configuration["Jwt:Audience"],
				notBefore: currentTime,
				claims: authClaims,
				expires: currentTime.Add(TimeSpan.FromMinutes(int.Parse(_configuration["Jwt:LifeTimeMinutes"]))), 
				signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256));

				var encodedJwt = new JwtSecurityTokenHandler().WriteToken(token);

				return encodedJwt;
			}

			return null;
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
