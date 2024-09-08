using SistemaAlarmes.Application.Interfaces;
using SistemaAlarmes.Application.Interfaces.Event;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;

namespace SistemaAlarmes.Application.UseCases
{
    public class GetElectrocenterByIdUseCase : IGetElectrocenterByIdUseCase
    {
        private readonly IEventRepository _eventRepository;

        public GetElectrocenterByIdUseCase(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<Domain.Entities.Event> ExecuteAsync(int id)
        {
            return await _eventRepository.GetByIdAsync(id);
        }

    }
}
