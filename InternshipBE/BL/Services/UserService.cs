using BL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
	public class UserService : IUserService
	{
		private readonly UserManager<User> _userManager;
		private readonly IConfiguration _configuration;

		public UserService(UserManager<User> userManager, IConfiguration configuration)
		{
			_userManager = userManager;
			_configuration = configuration;
		}

		public async Task<string> AuthenticateAsync(string email, string password)
		{
			var user = await _userManager.FindByEmailAsync(email);

			if (user != null && await _userManager.CheckPasswordAsync(user, password))
			{
				var roles = await _userManager.GetRolesAsync(user);
				var authClaims = new List<Claim>
				{
					new Claim(ClaimTypes.Name, user.UserName),
				};

				foreach(var role in roles)
				{
					authClaims.Add(new Claim(ClaimTypes.Role, role));
				}

				var authSigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

				var token = new JwtSecurityToken(
				_configuration["Jwt:Issuer"],
				_configuration["Jwt:Audience"],
				notBefore: DateTime.UtcNow,
				claims: authClaims,
				expires: DateTime.UtcNow.Add(TimeSpan.FromDays(int.Parse(_configuration["Jwt:LifeTimeInDays"]))), 
				signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256));

				var encodedJwt = new JwtSecurityTokenHandler().WriteToken(token);

				return encodedJwt;
			}

			return string.Empty;
		}
	}
}
