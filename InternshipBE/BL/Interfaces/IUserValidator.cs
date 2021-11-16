using DAL.Entities;

namespace BL.Interfaces
{
    public interface IUserValidator
    {
        public void ValidateIfUserExist(User user);
    }
}
