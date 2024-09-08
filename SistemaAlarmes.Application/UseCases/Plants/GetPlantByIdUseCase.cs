using SistemaAlarmes.Application.Interfaces.Plants;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;

namespace SistemaAlarmes.Application.UseCases.Plants
{
    public class GetPlantByIdUseCase : IGetPlantByIdUseCase
    {
        private readonly IPlantRepository _PlantRepository;

        public GetPlantByIdUseCase(IPlantRepository PlantRepository)
        {
            _PlantRepository = PlantRepository;
        }

        public async Task<Plant> ExecuteAsync(int id)
        {
            return await _PlantRepository.GetByIdAsync(id);
        }

    }
}
