using Microsoft.AspNetCore.Mvc;
using SistemaAlarmes.Application.Interfaces.Panels;

namespace SistemaAlarmes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PanelController : ControllerBase
    {
        private readonly IGetPanelByIdUseCase _getPanelByIdUseCase;
        private readonly IGetAllPanelsUseCase _getAllPanelUseCase;


        public PanelController(IGetPanelByIdUseCase getPanelByIdUseCase, IGetAllPanelsUseCase getAllPanelUseCase)
        {
            _getPanelByIdUseCase = getPanelByIdUseCase;
            _getAllPanelUseCase = getAllPanelUseCase;

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var PanelPi = await _getPanelByIdUseCase.ExecuteAsync(id);
            if (PanelPi == null)
                return NotFound();

            return Ok(PanelPi);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Panel = await _getAllPanelUseCase.ExecuteAsync();
            return Ok(Panel);
        }
    }
}
