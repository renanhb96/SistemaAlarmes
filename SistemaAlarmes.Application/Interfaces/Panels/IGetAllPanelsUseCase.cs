using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Application.Interfaces.Panels
{
    public interface IGetAllPanelsUseCase
    {
        Task<IEnumerable<Panel>> ExecuteAsync();
    }
}
