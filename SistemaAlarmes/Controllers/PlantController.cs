using Microsoft.AspNetCore.Mvc;
using SistemaAlarmes.Application.Interfaces.Plants;

namespace SistemaAlarmes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlantController : ControllerBase
    {
        private readonly IGetPlantByIdUseCase _getPlantByIdUseCase;
        private readonly IGetAllPlantsUseCase _getAllPlantUseCase;


        public PlantController(IGetPlantByIdUseCase getPlantByIdUseCase, IGetAllPlantsUseCase getAllPlantUseCase)
        {
            _getPlantByIdUseCase = getPlantByIdUseCase;
            _getAllPlantUseCase = getAllPlantUseCase;

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var PlantPi = await _getPlantByIdUseCase.ExecuteAsync(id);
            if (PlantPi == null)
                return NotFound();

            return Ok(PlantPi);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Plant = await _getAllPlantUseCase.ExecuteAsync();
            return Ok(Plant);
        }
    }
}
