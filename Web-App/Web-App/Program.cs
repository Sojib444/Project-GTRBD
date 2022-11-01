using Autofac.Extensions.DependencyInjection;
using Autofac;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Web_Api_Infrastructure;
using Web_App.ORM;

var builder = WebApplication.CreateBuilder(args);

//get connectionString
var connectionstring = builder.Configuration.GetConnectionString("connectionstring");
var assembly = Assembly.GetExecutingAssembly().FullName;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Setup DbContext

builder.Services.AddDbContext<ApplicationDbContext>(options => 
options.UseSqlServer(connectionstring,e=>e.MigrationsAssembly(assembly)));

//Setup Autofac

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule(new InfrastructureModule(connectionstring, assembly));
});

//setup Automapper

builder.Services.AddAutoMapper(typeof(Program).Assembly);

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
