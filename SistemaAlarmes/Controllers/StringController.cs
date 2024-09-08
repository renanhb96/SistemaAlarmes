using Microsoft.AspNetCore.Mvc;
using SistemaAlarmes.Application.Interfaces.Strings;

namespace SistemaAlarmes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StringController : ControllerBase
    {
        private readonly IGetStringByIdUseCase _getStringByIdUseCase;
        private readonly IGetAllStringsUseCase _getAllStringUseCase;


        public StringController(IGetStringByIdUseCase getStringByIdUseCase, IGetAllStringsUseCase getAllStringUseCase)
        {
            _getStringByIdUseCase = getStringByIdUseCase;
            _getAllStringUseCase = getAllStringUseCase;

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var StringPi = await _getStringByIdUseCase.ExecuteAsync(id);
            if (StringPi == null)
                return NotFound();

            return Ok(StringPi);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var String = await _getAllStringUseCase.ExecuteAsync();
            return Ok(String);
        }
    }
}
