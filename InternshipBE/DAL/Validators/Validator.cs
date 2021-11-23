using DAL.Interfaces;
using System;

namespace DAL.Validators
{
    public class Validator<T> : IValidator<T> where T : class
    {
        public void ValidateIfEntityExist(T value) 
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "value is null");
            }
        }
    }
}
