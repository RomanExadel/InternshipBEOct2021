using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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

		public void ValidateIfEntitesExist(List<T> values)
		{
			if (!values.Any())
			{
				throw new ArgumentNullException(nameof(values), $"{values} is empty");
			}
		}
	}
}
