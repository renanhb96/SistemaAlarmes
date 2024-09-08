using SistemaAlarmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Infrastructure.Interfaces
{
    public interface IEventCategoryRepository
    {
        Task<EventCategory> GetByIdAsync(int id);
        Task<IEnumerable<EventCategory>> GetAllAsync();
        Task AddAsync(EventCategory EventCategory);
    }
}
