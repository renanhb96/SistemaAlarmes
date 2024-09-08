using SistemaAlarmes.Application.Interfaces.Electrocenters;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;

namespace SistemaAlarmes.Application.UseCases.Electrocenters
{
    public class GetElectrocenterByIdUseCase : IGetElectrocenterByIdUseCase
    {
        private readonly IElectrocenterRepository _electrocenterRepository;

        public GetElectrocenterByIdUseCase(IElectrocenterRepository electrocenterRepository)
        {
            _electrocenterRepository = electrocenterRepository;
        }

        public async Task<Electrocenter> ExecuteAsync(int id)
        {
            return await _electrocenterRepository.GetByIdAsync(id);
        }

    }
}
