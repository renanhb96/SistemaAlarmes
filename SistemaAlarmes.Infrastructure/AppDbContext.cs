using SistemaAlarmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace SistemaAlarmes.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
