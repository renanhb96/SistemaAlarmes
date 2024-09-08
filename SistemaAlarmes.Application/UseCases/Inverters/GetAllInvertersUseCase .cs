using SistemaAlarmes.Application.Interfaces.Inverters;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;

namespace SistemaAlarmes.Application.UseCases.Inverters
{
    public class GetAllInvertersUseCase : IGetAllInvertersUseCase
    {
        private readonly IInverterRepository _inverterRepository;

        public GetAllInvertersUseCase(IInverterRepository InverterRepository)
        {
            _inverterRepository = InverterRepository;
        }

        public async Task<IEnumerable<Inverter>> ExecuteAsync()
        {
            return await _inverterRepository.GetAllAsync();
        }
    }
}
