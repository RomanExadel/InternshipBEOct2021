using AutoMapper;
using BL.DTOs;
using BL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Shared.Enums;
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
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<User> _validator;

        public UserService(UserManager<User> userManager, IConfiguration configuration, IMapper mapper, IUnitOfWork unitOfWork,
            IValidator<User> validator)
        {
            _userManager = userManager;
            _configuration = configuration;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _validator = validator;
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

                return new JwtSecurityTokenHandler().WriteToken(token);
            }

            return string.Empty;
        }

        public async Task<UserDTO> GetUserInfoByUserNameAsync(string userName)
        {
            var user = await GetUserByUserNameAsync(userName);

            _validator.ValidateIfEntityExists(user);

            var userDTO = _mapper.Map<UserDTO>(user);

            return userDTO;
        }

        public async Task<List<UserDTO>> GetSpecificUsersByInternshipIdAsync(int id, RoleType? roleType)
        {
            var mentors = await _unitOfWork.Users.GetSpecificUsersByInternshipIdAsync(id, roleType);

            var usersDTO = _mapper.Map<List<UserDTO>>(mentors);

            return usersDTO;
        }

        public async Task<List<UserDTO>> GetUsersByCandidateIdAsync(int id)
        {
            var users = await _unitOfWork.Users.GetUsersByCandidateIdAsync(id);

            var usersDTO = _mapper.Map<List<UserDTO>>(users);

            return usersDTO;
        }

        public async Task<List<UserDTO>> UpdateUsersFromInternshipAsync(int id, string[] userIds)
        {
            var result = await _unitOfWork.Users.UpdateUsersFromInternshipAsync(id, userIds);

            return _mapper.Map<List<UserDTO>>(result);
        }

        private async Task<User> GetUserByUserNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            _validator.ValidateIfEntityExists(user);

            return user;
        }

    }
}
