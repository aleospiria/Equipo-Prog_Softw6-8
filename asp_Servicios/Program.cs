using asp_Servicios.Controllers;
using lib_aplicaciones.Implementaciones;
using lib_aplicaciones.Interfaces;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.Configure<KestrelServerOptions>(x => { x.AllowSynchronousIO = true; });
builder.Services.Configure<IISServerOptions>(x => { x.AllowSynchronousIO = true; });
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//services.AddSwaggerGen();
builder.Services.AddScoped<Conexion, Conexion>();
// Repositorios
builder.Services.AddScoped<IAsignaturasRepositorio, AsignaturasRepositorio>();
// Aplicaciones
builder.Services.AddScoped<IAsignaturasAplicacion, AsignaturasAplicacion>();
// Controladores
builder.Services.AddScoped<TokenController, TokenController>();
builder.Services.AddCors(o => o.AddDefaultPolicy(b => b.AllowAnyOrigin()));


builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
