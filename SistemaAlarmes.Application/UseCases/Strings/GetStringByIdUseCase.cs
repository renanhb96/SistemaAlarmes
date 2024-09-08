using SistemaAlarmes.Application.Interfaces.Strings;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;
using String = SistemaAlarmes.Domain.Entities.String;

namespace SistemaAlarmes.Application.UseCases.Strings
{
    public class GetStringByIdUseCase : IGetStringByIdUseCase
    {
        private readonly IStringRepository _StringRepository;

        public GetStringByIdUseCase(IStringRepository StringRepository)
        {
            _StringRepository = StringRepository;
        }

        public async Task<String> ExecuteAsync(int id)
        {
            return await _StringRepository.GetByIdAsync(id);
        }

    }
}
