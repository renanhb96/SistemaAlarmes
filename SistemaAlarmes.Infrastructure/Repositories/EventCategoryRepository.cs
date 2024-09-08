using Microsoft.EntityFrameworkCore;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlarmes.Infrastructure.Repositories
{
    public class EventCategoryRepository : IEventCategoryRepository
    {
        private readonly AppDbContext _context;

        public EventCategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<EventCategory> GetByIdAsync(int id)
        {
            return await _context.EventCategories.FindAsync(id);
        }

        public async Task<IEnumerable<EventCategory>> GetAllAsync()
        {
            return await _context.EventCategories.ToListAsync();
        }

        public async Task AddAsync(EventCategory EventCategory)
        {
            await _context.EventCategories.AddAsync(EventCategory);
            await _context.SaveChangesAsync();
        }
    }
}
