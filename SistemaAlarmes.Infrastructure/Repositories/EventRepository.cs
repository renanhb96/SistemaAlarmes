using Microsoft.EntityFrameworkCore;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;



namespace SistemaAlarmes.Infrastructure.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly AppDbContext _context;

        public EventRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Event> GetByIdAsync(int id)
        {
            return await _context.Events.FindAsync(id);
        }

        public async Task<IEnumerable<Event>> GetAllAsync()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task AddAsync(Event @event)
        {
            await _context.Events.AddAsync(@event);
            await _context.SaveChangesAsync();
        }
    }
}
