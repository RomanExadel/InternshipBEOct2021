namespace DAL.Interfaces
{
    public interface IValidator<T> where T : class
    {
        public void ValidateIfEntityExist(T value);

        public void ValidateIfEntitesExist(List<T> values);
    }
}
