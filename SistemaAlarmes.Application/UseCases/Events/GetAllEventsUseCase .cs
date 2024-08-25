using SistemaAlarmes.Application.Interfaces;
using SistemaAlarmes.Application.Interfaces.Event;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;

namespace SistemaAlarmes.Application.UseCases
{
    public class GetAllEventsUseCase : IGetAllEventsUseCase
    {
        private readonly IEventRepository _eventRepository;

        public GetAllEventsUseCase(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<IEnumerable<Domain.Entities.Event>> ExecuteAsync()
        {
            return await _eventRepository.GetAllAsync();
        }
    }
}
