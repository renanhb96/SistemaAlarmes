using Microsoft.AspNetCore.Mvc;
using SistemaAlarmes.Application.Interfaces.Electrocenters;

namespace SistemaAlarmes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ElectrocenterController : ControllerBase
    {
        private readonly IGetElectrocenterByIdUseCase _getElectrocenterByIdUseCase;
        private readonly IGetAllElectrocentersUseCase _getAllElectrocenterUseCase;


        public ElectrocenterController(IGetElectrocenterByIdUseCase getElectrocenterByIdUseCase, IGetAllElectrocentersUseCase getAllElectrocenterUseCase)
        {
            _getElectrocenterByIdUseCase = getElectrocenterByIdUseCase;
            _getAllElectrocenterUseCase = getAllElectrocenterUseCase;

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ElectrocenterPi = await _getElectrocenterByIdUseCase.ExecuteAsync(id);
            if (ElectrocenterPi == null)
                return NotFound();

            return Ok(ElectrocenterPi);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Electrocenter = await _getAllElectrocenterUseCase.ExecuteAsync();
            return Ok(Electrocenter);
        }
    }
}
