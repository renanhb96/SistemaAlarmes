using SistemaAlarmes.Application.Interfaces;
using SistemaAlarmes.Application.UseCases;
using SistemaAlarmes.Infrastructure.Interfaces;
using SistemaAlarmes.Infrastructure.Repositories;
using SistemaAlarmes.Infrastructure.Services;
using SistemaAlarmes.Infrastructure;
using Microsoft.EntityFrameworkCore;
using SistemaAlarmes.Application.Interfaces.Email;
using SistemaAlarmes.Application.Interfaces.Event;
using SistemaAlarmes.Application.UseCases.Email;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register repositories and use cases
builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<IPlantRepository, PlantRepository>();
builder.Services.AddScoped<IElectrocenterRepository, ElectrocenterRepository>();
builder.Services.AddScoped<IInverterRepository, InverterRepository>();
builder.Services.AddScoped<IModuleRepository, ModuleRepository>();
builder.Services.AddScoped<IEmailSender, SmtpEmailSender>();
builder.Services.AddScoped<ISendEmailUseCase, SendEmailUseCase>();
builder.Services.AddScoped<IProcessEventUseCase, ProcessEventUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
