using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Application.Interfaces.Inverters
{
    public interface IGetInverterByIdUseCase
    {
        Task<Inverter> ExecuteAsync(int id);
    }

}
