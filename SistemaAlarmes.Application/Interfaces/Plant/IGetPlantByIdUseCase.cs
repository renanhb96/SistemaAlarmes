using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Application.Interfaces.Plants
{
    public interface IGetPlantByIdUseCase
    {
        Task<Plant> ExecuteAsync(int id);
    }

}
