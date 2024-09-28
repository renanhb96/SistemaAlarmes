using SistemaAlarmes.Domain.Entities;
using Module = SistemaAlarmes.Domain.Entities.Module;

namespace SistemaAlarmes.Application.Interfaces.Modules
{
    public interface IGetAllModulesUseCase
    {
        Task<IEnumerable<Module>> ExecuteAsync();
    }
}
