using SistemaAlarmes.Application.Interfaces.Plants;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;

namespace SistemaAlarmes.Application.UseCases.Plants
{
    public class GetAllPlantsUseCase : IGetAllPlantsUseCase
    {
        private readonly IPlantRepository _PlantRepository;

        public GetAllPlantsUseCase(IPlantRepository PlantRepository)
        {
            _PlantRepository = PlantRepository;
        }

        public async Task<IEnumerable<Plant>> ExecuteAsync()
        {
            return await _PlantRepository.GetAllAsync();
        }
    }
}
