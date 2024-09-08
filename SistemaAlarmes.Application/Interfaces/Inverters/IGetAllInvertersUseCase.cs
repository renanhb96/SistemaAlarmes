using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Application.Interfaces.Inverters
{
    public interface IGetAllInvertersUseCase
    {
        Task<IEnumerable<Inverter>> ExecuteAsync();
    }
}
