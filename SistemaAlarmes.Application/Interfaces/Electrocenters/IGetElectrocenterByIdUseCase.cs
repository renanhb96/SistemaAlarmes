using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Application.Interfaces.Electrocenters
{
    public interface IGetElectrocenterByIdUseCase
    {
        Task<Electrocenter> ExecuteAsync(int id);
    }

}
