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
    public class PanelRepository : IPanelRepository
    {
        private readonly AppDbContext _context;

        public PanelRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Panel> GetByIdAsync(int id)
        {
            return await _context.Panels.FindAsync(id);
        }

        public async Task<IEnumerable<Panel>> GetAllAsync()
        {
            return await _context.Panels.ToListAsync();
        }

        public async Task AddAsync(Panel Panel)
        {
            await _context.Panels.AddAsync(Panel);
            await _context.SaveChangesAsync();
        }
    }
}
