using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Infrastructure.Interfaces
{
    public interface IEventRepository
    {
        Task<Event> GetByIdAsync(int id);
        Task<IEnumerable<Event>> GetAllAsync();
        Task AddAsync(Event @event);
    }
}
