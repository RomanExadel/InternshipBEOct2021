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
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly IConfiguration _configuration;

		public UserService(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
		{
			_userManager = userManager;
			_configuration = configuration;
			_roleManager = roleManager;
		}

		public async Task<string> AuthenticateAsync(string login, string password)
		{
			var user = await _userManager.FindByEmailAsync(login);			

			if (user != null && await _userManager.CheckPasswordAsync(user, password))
			{
				await EnsureCreateRoleAsync(user);

				var roles = await _userManager.GetRolesAsync(user);
				var authClaims = new List<Claim>
				{
					new Claim(ClaimTypes.Name, user.UserName),
					new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
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

		private async Task EnsureCreateRoleAsync(User user) 
		{
			if (!await _roleManager.RoleExistsAsync(user.RoleType.ToString()))
			{
				await _roleManager.CreateAsync(new IdentityRole(user.RoleType.ToString()));
			}

			if (await _roleManager.RoleExistsAsync(user.RoleType.ToString()))
			{
				await _userManager.AddToRoleAsync(user, user.RoleType.ToString());
			}
		}
	}
}
