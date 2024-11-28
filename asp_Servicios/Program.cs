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
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<Conexion, Conexion>();
//Repositorios
builder.Services.AddScoped<IAsignaturasRepositorio, AsignaturasRepositorio>();
builder.Services.AddScoped<ICursosRepositorio, CursosRepositorio>();
builder.Services.AddScoped<IDepartamentosRepositorio, DepartamentosRepositorio>();
builder.Services.AddScoped<IEstudiantesRepositorio, EstudiantesRepositorio>();
builder.Services.AddScoped<IFacultadesRepositorio, FacultadesRepositorio>();
builder.Services.AddScoped<IProfesoresRepositorio, ProfesoresRepositorio>();
//Aplicaciones
builder.Services.AddScoped<IAsignaturasAplicacion, AsignaturasAplicacion>();
builder.Services.AddScoped<ICursosAplicacion, CursosAplicacion>();
builder.Services.AddScoped<IDepartamentosAplicacion, DepartamentosAplicacion>();
builder.Services.AddScoped<IEstudiantesAplicacion, EstudiantesAplicacion>();
builder.Services.AddScoped<IFacultadesAplicacion, FacultadesAplicacion>();
builder.Services.AddScoped<IProfesoresAplicacion, ProfesoresAplicacion>();

//Controladores
builder.Services.AddScoped<TokenController, TokenController>();
builder.Services.AddScoped<AsignaturasController, AsignaturasController>();
builder.Services.AddScoped<CursosController, CursosController>();
builder.Services.AddScoped<DepartamentosController, DepartamentosController>();
builder.Services.AddScoped<EstudiantesController, EstudiantesController>();
builder.Services.AddScoped<FacultadesController, FacultadesController>();
builder.Services.AddScoped<ProfesoresController, ProfesoresController>();
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
