using SistemaAlarmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Infrastructure.Interfaces
{
    public interface IInverterRepository
    {
        Task<Inverter> GetByIdAsync(int id);
        Task<IEnumerable<Inverter>> GetAllAsync();
        Task AddAsync(Inverter Inverter);
    }
}
