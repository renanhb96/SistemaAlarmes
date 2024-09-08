using Microsoft.AspNetCore.Mvc;
using SistemaAlarmes.Application.Interfaces.Inverters;

namespace SistemaAlarmes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InverterController : ControllerBase
    {
        private readonly IGetInverterByIdUseCase _getInverterByIdUseCase;
        private readonly IGetAllInvertersUseCase _getAllInverterUseCase;


        public InverterController(IGetInverterByIdUseCase getInverterByIdUseCase, IGetAllInvertersUseCase getAllInverterUseCase)
        {
            _getInverterByIdUseCase = getInverterByIdUseCase;
            _getAllInverterUseCase = getAllInverterUseCase;

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var InverterPi = await _getInverterByIdUseCase.ExecuteAsync(id);
            if (InverterPi == null)
                return NotFound();

            return Ok(InverterPi);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Inverter = await _getAllInverterUseCase.ExecuteAsync();
            return Ok(Inverter);
        }
    }
}
