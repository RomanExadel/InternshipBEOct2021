using BL.Interfaces;
using System;
using System.Collections.Generic;

namespace BL.Validators
{
    public class Validator<T> : IValidator<T> where T : class
    {
        public void ValidateIfEntityExist(T value) 
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), $"{value} is null");
            }
        }

        public void ValidateIfEntityExist(List<T> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), $"{values} is empty");
            }
        }
    }
}
