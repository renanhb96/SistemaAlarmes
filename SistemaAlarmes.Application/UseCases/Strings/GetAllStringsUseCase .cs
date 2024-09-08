using SistemaAlarmes.Application.Interfaces.Strings;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;
using String = SistemaAlarmes.Domain.Entities.String;

namespace SistemaAlarmes.Application.UseCases.Strings
{
    public class GetAllStringsUseCase : IGetAllStringsUseCase
    {
        private readonly IStringRepository _StringRepository;

        public GetAllStringsUseCase(IStringRepository StringRepository)
        {
            _StringRepository = StringRepository;
        }

        public async Task<IEnumerable<String>> ExecuteAsync()
        {
            return await _StringRepository.GetAllAsync();
        }
    }
}
