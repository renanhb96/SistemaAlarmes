using Microsoft.AspNetCore.Mvc;
using SistemaAlarmes.Application.Services;
using SistemaAlarmes.Domain.Entities;

namespace SistemaAlarmes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly EventService _eventService;

        public EventsController(EventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Event @event)
        {
            await _eventService.AddAsync(@event);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var @event = await _eventService.GetByIdAsync(id);
            if (@event == null)
                return NotFound();

            return Ok(@event);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var events = await _eventService.GetAllAsync();
            return Ok(events);
        }
    }
}
