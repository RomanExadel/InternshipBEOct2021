using DAL.Entities;

namespace BL.Interfaces
{
    public interface IInternshipValidator
    {
        public void ValidateIfInternshipExist(Internship internship);
    }
}
