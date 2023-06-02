using LeveMv.Application.InterfacesServices;
using LeveMv.Application.Services;
using LeveMv.Data.Context;
using LeveMv.Data.Repositories;
using LeveMv.Domain.InterfacesRepositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<LeveMeContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));
builder.Services.AddControllers();

//Dependencia Repository
builder.Services.AddScoped<ILeveMeRepository, LeveMeRepository>();

//Dependencia Services
builder.Services.AddScoped<ILeveMeService, LeveMeService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
