using SistemaAlarmes.Application.Interfaces.Panels;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;

namespace SistemaAlarmes.Application.UseCases.Panels
{
    public class GetAllPanelsUseCase : IGetAllPanelsUseCase
    {
        private readonly IPanelRepository _PanelRepository;

        public GetAllPanelsUseCase(IPanelRepository PanelRepository)
        {
            _PanelRepository = PanelRepository;
        }

        public async Task<IEnumerable<Panel>> ExecuteAsync()
        {
            return await _PanelRepository.GetAllAsync();
        }
    }
}
