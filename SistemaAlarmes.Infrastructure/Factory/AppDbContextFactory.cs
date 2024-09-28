using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Design;

using Microsoft.Extensions.Configuration;
using SistemaAlarmes.Infrastructure;


public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>

{

    public AppDbContext CreateDbContext(string[] args)

    {

        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();


        var currentDirectory = Directory.GetCurrentDirectory();

        var appSettingsPath = Path.Combine(currentDirectory, "..", "SistemaAlarmes", "appsettings.json");
        Console.WriteLine($"AppSettings Path: {appSettingsPath}");

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(currentDirectory)
            .AddJsonFile(appSettingsPath, optional: false, reloadOnChange: true)
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("SistemaAlarmes.Infrastructure"));

        return new AppDbContext(optionsBuilder.Options);

    }

}