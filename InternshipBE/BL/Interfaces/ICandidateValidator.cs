using DAL.Entities;

namespace BL.Interfaces
{
    public interface ICandidateValidator
    {
        public void ValidateIfCandidateExist(Candidate candidate);
    }
}
