using Cadastro.Command;
using Cadastro.Command.Contracts;
using Cadastro.CommandStore;
using Cadastro.Query;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(CadastroCommandHandler));
builder.Services.AddMediatR(typeof(RetornarAlunosQueryHandler));
builder.Services.AddDbContext<CadastroContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("cadastro")));
builder.Services.AddScoped<IPessoaCommandStore, PessoaCommandStore>();
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
