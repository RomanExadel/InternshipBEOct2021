using BL.Interfaces;
using DAL.Entities;
using System;

namespace BL.Validators
{
    public class UserValidator : IUserValidator
    {
        public void ValidateIfUserExist(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "user is null");
            }
        }
    }
}
