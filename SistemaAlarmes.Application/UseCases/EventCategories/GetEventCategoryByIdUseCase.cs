using SistemaAlarmes.Application.Interfaces.EventCategories;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;

namespace SistemaAlarmes.Application.UseCases.EventCategories
{
    public class GetEventCategoryByIdUseCase : IGetEventCategoryByIdUseCase
    {
        private readonly IEventCategoryRepository _EventCategoryRepository;

        public GetEventCategoryByIdUseCase(IEventCategoryRepository EventCategoryRepository)
        {
            _EventCategoryRepository = EventCategoryRepository;
        }

        public async Task<EventCategory> ExecuteAsync(int id)
        {
            return await _EventCategoryRepository.GetByIdAsync(id);
        }

    }
}
