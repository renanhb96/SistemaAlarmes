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
    public class PlantRepository : IPlantRepository
    {
        private readonly AppDbContext _context;

        public PlantRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Plant> GetByIdAsync(int id)
        {
            return await _context.Plants.FindAsync(id);
        }

        public async Task<IEnumerable<Plant>> GetAllAsync()
        {
            return await _context.Plants.ToListAsync();
        }

        public async Task AddAsync(Plant Plant)
        {
            await _context.Plants.AddAsync(Plant);
            await _context.SaveChangesAsync();
        }
    }
}
