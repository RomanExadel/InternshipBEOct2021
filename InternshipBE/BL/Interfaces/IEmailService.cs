using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(int candidateId);
        Task SendEmailAsync(int candidateId, string emailText);
    }
}
