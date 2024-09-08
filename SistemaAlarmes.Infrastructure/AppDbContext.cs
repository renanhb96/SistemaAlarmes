using Microsoft.EntityFrameworkCore;
using SistemaAlarmes.Domain.Entities;
using String = SistemaAlarmes.Domain.Entities.String;

namespace SistemaAlarmes.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Electrocenter> Electrocenters { get; set; }
        public DbSet<Inverter> Inverters { get; set; }
        public DbSet<String> Strings { get; set; }
        public DbSet<Panel> Panels { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
