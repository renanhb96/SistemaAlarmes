using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Application.Interfaces.EventCategories
{
    public interface IGetAllEventCategoriesUseCase
    {
        Task<IEnumerable<EventCategory>> ExecuteAsync();
    }
}
