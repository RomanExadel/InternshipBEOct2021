using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string text);
    }
}
