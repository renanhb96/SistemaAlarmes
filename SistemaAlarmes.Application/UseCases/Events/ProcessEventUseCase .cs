using Microsoft.Extensions.Logging;
using SistemaAlarmes.Application.Interfaces.Email;
using SistemaAlarmes.Application.Interfaces.Event;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Domain.Enums;
using SistemaAlarmes.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Application.UseCases.Event
{
    public class ProcessEventUseCase : IProcessEventUseCase
    {
        private readonly IEventRepository _eventRepository;
        private readonly ISendEmailUseCase _sendEmailUseCase;

        public ProcessEventUseCase(IEventRepository eventRepository, ISendEmailUseCase sendEmailUseCase)
        {
            _eventRepository = eventRepository;
            _sendEmailUseCase = sendEmailUseCase;
        }

        public async Task ExecuteAsync(Domain.Entities.Event eventItem)
        {
            // Salva o evento no banco
            await _eventRepository.AddAsync(eventItem);

            // Envia email se o evento for crítico
            if (eventItem.EventType == EventType.Critical.ToString())
            {
                string subject = "Critical Event Alert";
                string body = $"A critical event occurred: {eventItem.AssetName}. Description: {eventItem.Description}";
                await _sendEmailUseCase.ExecuteAsync("operator@yourcompany.com", subject, body);
            }
        }
    }
}
