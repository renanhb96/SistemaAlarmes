using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Application.Interfaces.Electrocenters
{
    public interface IGetAllElectrocentersUseCase
    {
        Task<IEnumerable<Electrocenter>> ExecuteAsync();
    }
}
