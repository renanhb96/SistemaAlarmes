using Microsoft.AspNetCore.Mvc;
using SistemaAlarmes.Application.Interfaces.Event;
using SistemaAlarmes.Application.Services;
using SistemaAlarmes.Application.UseCases;
using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IProcessEventUseCase _processEventUseCase;
        private readonly IGetEventByIdUseCase _getEventByIdUseCase;
        private readonly IGetAllEventsUseCase _getAllEventsUseCase;


        public EventsController(IProcessEventUseCase processEventUseCase, IGetEventByIdUseCase getEventByIdUseCase, IGetAllEventsUseCase getAllEventsUseCase)
        {
            _processEventUseCase = processEventUseCase;
            _getEventByIdUseCase = getEventByIdUseCase;
            _getAllEventsUseCase = getAllEventsUseCase;

        }

        [HttpPost]
        public async Task<IActionResult> ReceiveEvent([FromBody] Event eventItem)
        {
            await _processEventUseCase.ExecuteAsync(eventItem);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var eventPi = await _getEventByIdUseCase.ExecuteAsync(id);
            if (eventPi == null)
                return NotFound();

            return Ok(eventPi);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var events = await _getAllEventsUseCase.ExecuteAsync();
            return Ok(events);
        }
    }
}
