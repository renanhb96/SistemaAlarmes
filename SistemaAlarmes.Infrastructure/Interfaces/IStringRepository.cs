using SistemaAlarmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String = SistemaAlarmes.Domain.Entities.String;

namespace SistemaAlarmes.Infrastructure.Interfaces
{
    public interface IStringRepository
    {
        Task<String> GetByIdAsync(int id);
        Task<IEnumerable<String>> GetAllAsync();
        Task AddAsync(String String);
    }
}
