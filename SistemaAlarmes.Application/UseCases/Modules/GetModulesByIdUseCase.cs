using SistemaAlarmes.Application.Interfaces.Modules;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;
using Module = SistemaAlarmes.Domain.Entities.Module;

namespace SistemaAlarmes.Application.UseCases.Strings
{
    public class GetStringByIdUseCase : IGetModulesByIdUseCase
    {
        private readonly IModuleRepository _ModuleRepository;

        public GetStringByIdUseCase(IModuleRepository ModuleRepository)
        {
            _ModuleRepository = ModuleRepository;
        }

        public async Task<Module> ExecuteAsync(int id)
        {
            return await _ModuleRepository.GetByIdAsync(id);
        }

    }
}
