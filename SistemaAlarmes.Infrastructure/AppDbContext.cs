using Microsoft.EntityFrameworkCore;
using SistemaAlarmes.Domain.Entities;
using Module = SistemaAlarmes.Domain.Entities.Module;

namespace SistemaAlarmes.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> EventCategories { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Electrocenter> Electrocenters { get; set; }
        public DbSet<Inverter> Inverters { get; set; }
        public DbSet<Module> Modules { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar relacionamento entre Evento e Planta
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Plant)
                .WithMany(p => p.Events)
                .HasForeignKey(e => e.PlantId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Electrocenter)
                .WithMany(ec => ec.Events)
                .HasForeignKey(e => e.ElectrocenterId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Inverter)
                .WithMany(i => i.Events)
                .HasForeignKey(e => e.InverterId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Module)
                .WithMany(m => m.Events)
                .HasForeignKey(e => e.ModuleId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Event>()
                .HasOne(e => e.EventCategory)
                .WithMany(ec => ec.Events)
                .HasForeignKey(e => e.EventCategoryId)
                .OnDelete(DeleteBehavior.Restrict); 

            // Configurações de relacionamentos hierárquicos

            // Planta possui muitos Eletrocentros
            modelBuilder.Entity<Plant>()
                .HasMany(p => p.Electrocenters)
                .WithOne(ec => ec.Plant)
                .HasForeignKey(ec => ec.PlantId)
                .OnDelete(DeleteBehavior.Cascade); 

            // Eletrocentro possui muitos Inversores
            modelBuilder.Entity<Electrocenter>()
                .HasMany(ec => ec.Inverters)
                .WithOne(i => i.Electrocenter)
                .HasForeignKey(i => i.ElectrocenterId)
                .OnDelete(DeleteBehavior.Cascade); 

            // Inversor possui muitos Módulos
            modelBuilder.Entity<Inverter>()
                .HasMany(i => i.Modules)
                .WithOne(m => m.Inverter)
                .HasForeignKey(m => m.InverterId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Event>()
                .Property(e => e.PlantId)
                .IsRequired(false); 

            modelBuilder.Entity<Event>()
                .Property(e => e.ElectrocenterId)
                .IsRequired(false); 

            modelBuilder.Entity<Event>()
                .Property(e => e.InverterId)
                .IsRequired(false); 

            modelBuilder.Entity<Event>()
                .Property(e => e.ModuleId)
                .IsRequired(false);
            modelBuilder.Entity<Event>()
                .HasKey(x => x.IdEventFramePISystem);

            base.OnModelCreating(modelBuilder);
        }

    }
}
