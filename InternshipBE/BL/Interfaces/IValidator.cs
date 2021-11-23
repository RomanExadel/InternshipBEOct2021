using System.Collections.Generic;

namespace BL.Interfaces
{
    public interface IValidator<T> where T : class
    {
        public void ValidateIfEntityExist(T value);

        public void ValidateIfEntityExist(List<T> values);
    }
}
