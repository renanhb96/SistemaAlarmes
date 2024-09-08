using SistemaAlarmes.Application.Interfaces.Electrocenters;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;

namespace SistemaAlarmes.Application.UseCases.Electrocenters
{
    public class GetAllElectrocentersUseCase : IGetAllElectrocentersUseCase
    {
        private readonly IElectrocenterRepository _ElectrocenterRepository;

        public GetAllElectrocentersUseCase(IElectrocenterRepository ElectrocenterRepository)
        {
            _ElectrocenterRepository = ElectrocenterRepository;
        }

        public async Task<IEnumerable<Electrocenter>> ExecuteAsync()
        {
            return await _ElectrocenterRepository.GetAllAsync();
        }
    }
}
