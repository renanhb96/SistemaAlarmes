using SistemaAlarmes.Application.Interfaces.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Application.UseCases.Email
{
    public class SendEmailUseCase : ISendEmailUseCase
    {
        private readonly IEmailSender _emailSender;

        public SendEmailUseCase(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public async Task ExecuteAsync(string to, string subject, string body)
        {
            // Chama o serviço de envio de email real, que pode ser um SMTP, SendGrid, etc.
            await _emailSender.SendEmailAsync(to, subject, body);
        }

    }
}
