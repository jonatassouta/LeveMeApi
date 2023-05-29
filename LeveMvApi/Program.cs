using LeveMv.Application.InterfacesServices;
using LeveMv.Application.Services;
using LeveMv.Data.Context;
using LeveMv.Data.Repositories;
using LeveMv.Domain.InterfacesRepositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<LeveMvContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));
builder.Services.AddControllers();

//Dependencia Repository
builder.Services.AddScoped<ILeveMvRepository, LeveMvRepository>();

//Dependencia Services
builder.Services.AddScoped<ILeveMvService, LeveMvService>();

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
