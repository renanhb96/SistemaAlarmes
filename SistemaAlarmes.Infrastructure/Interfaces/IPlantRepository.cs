using SistemaAlarmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Infrastructure.Interfaces
{
    public interface IPlantRepository
    {
        Task<Plant> GetByIdAsync(int id);
        Task<IEnumerable<Plant>> GetAllAsync();
        Task AddAsync(Plant Plant);
    }
}
