using Microsoft.EntityFrameworkCore;
using FKFromAnotherDB.EFCore.Configurator;
using FKFromAnotherDB.EFCore.SCADA;
using FKFromAnotherDB.Exstentions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ScadaDBContext>(
    options => options.UseNpgsql("name=ConnectionStrings:ScadaConnection"));
builder.Services.AddDbContext<ConfDBContext>(
    options => options.UseNpgsql("name=ConnectionStrings:ConfConnection"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.SeedDB();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
