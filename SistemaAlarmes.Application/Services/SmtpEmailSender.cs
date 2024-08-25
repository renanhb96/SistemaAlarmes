using SistemaAlarmes.Application.Interfaces.Email;
using System.Net;
using System.Net.Mail;

namespace SistemaAlarmes.Infrastructure.Services
{
    public class SmtpEmailSender : IEmailSender
    {
        private readonly SmtpClient _smtpClient;

        public SmtpEmailSender()
        {
            _smtpClient = new SmtpClient("smtp.your-email-provider.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("your-email@example.com", "your-password"),
                EnableSsl = true,
            };
        }

        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var mailMessage = new MailMessage("your-email@example.com", to, subject, body);
            await _smtpClient.SendMailAsync(mailMessage);
        }
    }
}
