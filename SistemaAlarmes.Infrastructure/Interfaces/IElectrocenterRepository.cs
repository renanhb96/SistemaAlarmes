using SistemaAlarmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Infrastructure.Interfaces
{
    public interface IElectrocenterRepository
    {
        Task<Electrocenter> GetByIdAsync(int id);
        Task<IEnumerable<Electrocenter>> GetAllAsync();
        Task AddAsync(Electrocenter Electrocenter);
    }
}
