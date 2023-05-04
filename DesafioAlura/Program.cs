using AdoPet.Repository;
using AdoPet.Servicos.Interfaces;
using DesafioAlura.Context;
using DesafioAlura.DTOs.Pet;
using DesafioAlura.Entidades;
using DesafioAlura.Repository;
using DesafioAlura.Servicos;
using DesafioAlura.Validadores;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var conectionString = builder.Configuration.GetConnectionString("AdoPetConection");

builder.Services.AddDbContext<AdoPetContext>(options => options.UseSqlServer(conectionString));

builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
builder.Services.AddScoped<IServico,UsuarioServico>();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers().AddNewtonsoftJson().AddFluentValidation(Config =>
{
    Config.RegisterValidatorsFromAssembly(typeof(Program).Assembly);
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
