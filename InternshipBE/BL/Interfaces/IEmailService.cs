using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(int recipientId);
    }
}
