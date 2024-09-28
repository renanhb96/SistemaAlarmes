using Microsoft.EntityFrameworkCore;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module = SistemaAlarmes.Domain.Entities.Module;

namespace SistemaAlarmes.Infrastructure.Repositories
{
    public class ModuleRepository : IModuleRepository
    {
        private readonly AppDbContext _context;

        public ModuleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Module> GetByIdAsync(int id)
        {
            return await _context.Strings.FindAsync(id);
        }

        public async Task<IEnumerable<Module>> GetAllAsync()
        {
            return await _context.Strings.ToListAsync();
        }

        public async Task AddAsync(Module Module)
        {
            await _context.Strings.AddAsync(Module);
            await _context.SaveChangesAsync();
        }
    }
}
