using SistemaAlarmes.Application.Interfaces.Panels;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;

namespace SistemaAlarmes.Application.UseCases.Panels
{
    public class GetPanelByIdUseCase : IGetPanelByIdUseCase
    {
        private readonly IPanelRepository _PanelRepository;

        public GetPanelByIdUseCase(IPanelRepository PanelRepository)
        {
            _PanelRepository = PanelRepository;
        }

        public async Task<Panel> ExecuteAsync(int id)
        {
            return await _PanelRepository.GetByIdAsync(id);
        }

    }
}
