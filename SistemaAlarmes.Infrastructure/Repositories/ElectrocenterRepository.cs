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
    public class ElectrocenterRepository : IElectrocenterRepository
    {
        private readonly AppDbContext _context;

        public ElectrocenterRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Electrocenter> GetByIdAsync(int id)
        {
            return await _context.Electrocenters.FindAsync(id);
        }

        public async Task<IEnumerable<Electrocenter>> GetAllAsync()
        {
            return await _context.Electrocenters.ToListAsync();
        }

        public async Task AddAsync(Electrocenter Electrocenter)
        {
            await _context.Electrocenters.AddAsync(Electrocenter);
            await _context.SaveChangesAsync();
        }
    }
}
