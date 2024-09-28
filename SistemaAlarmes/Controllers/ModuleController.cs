using Microsoft.AspNetCore.Mvc;
using SistemaAlarmes.Application.Interfaces.Modules;

namespace SistemaAlarmes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModuleController : ControllerBase
    {
        private readonly IGetModulesByIdUseCase _getModuleByIdUseCase;
        private readonly IGetAllModulesUseCase _getAllModuleUseCase;


        public ModuleController(IGetModulesByIdUseCase getStringByIdUseCase, IGetAllModulesUseCase getAllModuleUseCase)
        {
            _getModuleByIdUseCase = getStringByIdUseCase;
            _getAllModuleUseCase = getAllModuleUseCase;

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var StringPi = await _getModuleByIdUseCase.ExecuteAsync(id);
            if (StringPi == null)
                return NotFound();

            return Ok(StringPi);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Module = await _getAllModuleUseCase.ExecuteAsync();
            return Ok(Module);
        }
    }
}
