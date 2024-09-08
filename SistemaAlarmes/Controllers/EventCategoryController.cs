using Microsoft.AspNetCore.Mvc;
using SistemaAlarmes.Application.Interfaces.EventCategories;

namespace SistemaAlarmes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventCategoryController : ControllerBase
    {
        private readonly IGetEventCategoryByIdUseCase _getEventCategoryByIdUseCase;
        private readonly IGetAllEventCategoriesUseCase _getAllEventCategoryUseCase;


        public EventCategoryController(IGetEventCategoryByIdUseCase getEventCategoryByIdUseCase, IGetAllEventCategoriesUseCase getAllEventCategoryUseCase)
        {
            _getEventCategoryByIdUseCase = getEventCategoryByIdUseCase;
            _getAllEventCategoryUseCase = getAllEventCategoryUseCase;

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var EventCategoryPi = await _getEventCategoryByIdUseCase.ExecuteAsync(id);
            if (EventCategoryPi == null)
                return NotFound();

            return Ok(EventCategoryPi);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var EventCategory = await _getAllEventCategoryUseCase.ExecuteAsync();
            return Ok(EventCategory);
        }
    }
}
