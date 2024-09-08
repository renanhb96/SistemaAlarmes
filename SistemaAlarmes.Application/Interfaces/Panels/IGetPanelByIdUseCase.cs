using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Application.Interfaces.Panels
{
    public interface IGetPanelByIdUseCase
    {
        Task<Panel> ExecuteAsync(int id);
    }

}
