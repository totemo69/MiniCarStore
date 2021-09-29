using MiniCarStore.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCarStore.Infrastructure.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            // TODO: Sendgrid
            return Task.CompletedTask;
        }
    }
}
