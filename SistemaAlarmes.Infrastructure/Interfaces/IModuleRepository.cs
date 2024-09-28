using SistemaAlarmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module = SistemaAlarmes.Domain.Entities.Module;

namespace SistemaAlarmes.Infrastructure.Interfaces
{
    public interface IModuleRepository
    {
        Task<Module> GetByIdAsync(int id);
        Task<IEnumerable<Module>> GetAllAsync();
        Task AddAsync(Module Module);
    }
}
