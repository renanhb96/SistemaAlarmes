using SistemaAlarmes.Application.Interfaces.Modules;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;
using Module = SistemaAlarmes.Domain.Entities.Module;

namespace SistemaAlarmes.Application.UseCases.Strings
{
    public class GetAllStringsUseCase : IGetAllModulesUseCase
    {
        private readonly IModuleRepository _ModuleRepository;

        public GetAllStringsUseCase(IModuleRepository ModuleRepository)
        {
            _ModuleRepository = ModuleRepository;
        }

        public async Task<IEnumerable<Module>> ExecuteAsync()
        {
            return await _ModuleRepository.GetAllAsync();
        }
    }
}
