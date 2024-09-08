using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Application.Interfaces.Plants
{
    public interface IGetAllPlantsUseCase
    {
        Task<IEnumerable<Plant>> ExecuteAsync();
    }
}
