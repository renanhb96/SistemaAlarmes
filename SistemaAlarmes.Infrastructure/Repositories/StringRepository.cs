using Microsoft.EntityFrameworkCore;
using SistemaAlarmes.Domain.Entities;
using SistemaAlarmes.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String = SistemaAlarmes.Domain.Entities.String;

namespace SistemaAlarmes.Infrastructure.Repositories
{
    public class StringRepository : IStringRepository
    {
        private readonly AppDbContext _context;

        public StringRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<String> GetByIdAsync(int id)
        {
            return await _context.Strings.FindAsync(id);
        }

        public async Task<IEnumerable<String>> GetAllAsync()
        {
            return await _context.Strings.ToListAsync();
        }

        public async Task AddAsync(String String)
        {
            await _context.Strings.AddAsync(String);
            await _context.SaveChangesAsync();
        }
    }
}
