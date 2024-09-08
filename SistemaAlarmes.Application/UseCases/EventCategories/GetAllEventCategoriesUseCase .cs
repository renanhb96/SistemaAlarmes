using SistemaAlarmes.Application.Interfaces.EventCategories;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;

namespace SistemaAlarmes.Application.UseCases.EventCategories
{
    public class GetAllEventCategoriesUseCase : IGetAllEventCategoriesUseCase
    {
        private readonly IEventCategoryRepository _EventCategoryRepository;

        public GetAllEventCategoriesUseCase(IEventCategoryRepository EventCategoryRepository)
        {
            _EventCategoryRepository = EventCategoryRepository;
        }

        public async Task<IEnumerable<EventCategory>> ExecuteAsync()
        {
            return await _EventCategoryRepository.GetAllAsync();
        }
    }
}
