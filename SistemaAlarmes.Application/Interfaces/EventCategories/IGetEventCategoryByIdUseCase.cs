using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Application.Interfaces.EventCategories
{
    public interface IGetEventCategoryByIdUseCase
    {
        Task<EventCategory> ExecuteAsync(int id);
    }

}
