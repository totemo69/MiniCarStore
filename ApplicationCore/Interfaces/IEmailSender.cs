using System.Threading.Tasks;

namespace MiniCarStore.ApplicationCore.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
