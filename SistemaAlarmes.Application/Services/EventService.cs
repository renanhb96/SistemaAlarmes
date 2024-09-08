using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Domain.Enums;
using SistemaAlarmes.Infrastructure.Interfaces;
using System.Net.Mail;

namespace SistemaAlarmes.Application.Services
{
    public class EventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly string _emailRecipient;

        public EventService(IEventRepository eventRepository, string emailRecipient)
        {
            _eventRepository = eventRepository;
            _emailRecipient = emailRecipient;
        }

        public async Task<Event> GetByIdAsync(int id)
        {
            return await _eventRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Event>> GetAllAsync()
        {
            return await _eventRepository.GetAllAsync();
        }

        public async Task AddAsync(Event eventPi)
        {
            await _eventRepository.AddAsync(eventPi);
            if (eventPi.Severity == SeverityType.Critical.ToString())
            {
                await SendMaintenanceEmail(eventPi);
            }
        }
        //TODO criar um emailService separado
        private async Task SendMaintenanceEmail(Event eventPi)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress("noreply@yourcompany.com"),
                Subject = "Maintenance Required: " + eventPi.AssetType,
                Body = $"Asset: {eventPi.AssetType}\nTimestamp: {eventPi.StartDate}\nDescription: {eventPi.Description}",
                IsBodyHtml = false
            };

            mailMessage.To.Add(_emailRecipient);
            //TODO criar um smtp
            using (var smtpClient = new SmtpClient("smtp.yourcompany.com"))
            {
                smtpClient.Port = 587; // Ajuste conforme necessário
                smtpClient.Credentials = new System.Net.NetworkCredential("username", "password");
                smtpClient.EnableSsl = true;
                await smtpClient.SendMailAsync(mailMessage);
            }
        }
    }
}
