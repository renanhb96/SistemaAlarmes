using SistemaAlarmes.Application.Interfaces.Inverters;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;

namespace SistemaAlarmes.Application.UseCases.Inverters
{
    public class GetStringByIdUseCase : IGetInverterByIdUseCase
    {
        private readonly IInverterRepository _inverterRepository;

        public GetStringByIdUseCase(IInverterRepository InverterRepository)
        {
            _inverterRepository = InverterRepository;
        }

        public async Task<Inverter> ExecuteAsync(int id)
        {
            return await _inverterRepository.GetByIdAsync(id);
        }

    }
}
