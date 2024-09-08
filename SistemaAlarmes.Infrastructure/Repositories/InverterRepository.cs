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
    public class InverterRepository : IInverterRepository
    {
        private readonly AppDbContext _context;

        public InverterRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Inverter> GetByIdAsync(int id)
        {
            return await _context.Inverters.FindAsync(id);
        }

        public async Task<IEnumerable<Inverter>> GetAllAsync()
        {
            return await _context.Inverters.ToListAsync();
        }

        public async Task AddAsync(Inverter Inverter)
        {
            await _context.Inverters.AddAsync(Inverter);
            await _context.SaveChangesAsync();
        }
    }
}
