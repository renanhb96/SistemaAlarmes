using SistemaAlarmes.Domain.Entities;
using Module = SistemaAlarmes.Domain.Entities.Module;

namespace SistemaAlarmes.Application.Interfaces.Modules
{
    public interface IGetModulesByIdUseCase
    {
        Task<Module> ExecuteAsync(int id);
    }

}
