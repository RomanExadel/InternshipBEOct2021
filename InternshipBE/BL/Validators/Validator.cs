using BL.Interfaces;
using System;

namespace BL.Validators
{
    public class Validator<T> : IValidator<T> where T : class
    {
        public void ValidateIfValueExist(T value) 
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), $"{value} is null");
            }
        }
    }
}
