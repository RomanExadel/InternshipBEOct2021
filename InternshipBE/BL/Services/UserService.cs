﻿using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Shared.Enums;
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
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager, IConfiguration configuration, IMapper mapper)
        {
            _userManager = userManager;
            _configuration = configuration;
            _mapper = mapper;
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
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                foreach (var role in roles)
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

        public async Task<UserDTO> GetUserByUserNameAsync(string userName)
        {
            var user = await CheckPresenceUserAsync(userName);

            var userRole = await GetUserRoleAsync(user);

            var userDTO = _mapper.Map<UserDTO>(user);

            userDTO.RoleType = Enum.Parse<RoleType>(userRole);

            return userDTO;
        }

        private async Task<string> GetUserRoleAsync(User user)
        {
            var roles = await _userManager.GetRolesAsync(user); 
            
            if (roles == null)
            {
                throw new ArgumentNullException(nameof(roles),"roles is null");
            }
            
            string userRole = roles.SingleOrDefault(); 

            return userRole;
        }

        private async Task<User> CheckPresenceUserAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user),"user is null");
            }

            return user;
        }

    }
}
