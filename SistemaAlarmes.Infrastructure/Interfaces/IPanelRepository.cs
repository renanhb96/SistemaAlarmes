using SistemaAlarmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Infrastructure.Interfaces
{
    public interface IPanelRepository
    {
        Task<Panel> GetByIdAsync(int id);
        Task<IEnumerable<Panel>> GetAllAsync();
        Task AddAsync(Panel Panel);
    }
}
