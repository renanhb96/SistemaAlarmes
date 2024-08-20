using SistemaAlarmes.Application.Services;
using SistemaAlarmes.Infrastructure.Interfaces;
using SistemaAlarmes.Infrastructure.Repositories;
using SistemaAlarmes.Infrastructure;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure services
builder.Services.AddControllers();
//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<EventService>(provider =>
    new EventService(provider.GetRequiredService<IEventRepository>(), "operator@yourcompany.com"));


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
