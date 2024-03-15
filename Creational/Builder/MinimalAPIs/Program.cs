using FluentValidation;
using Mapster;
using MapsterMapper;
using System.Reflection;
using Thisisnabi.DesignPattern.Creational.Builder.MinimalAPIs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddValidatorsFromAssemblyContaining<AppDbContext>();

var config = TypeAdapterConfig.GlobalSettings;
config.Scan(Assembly.GetExecutingAssembly());

builder.Services.AddSingleton(config);
builder.Services.AddScoped<IMapper, ServiceMapper>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapEntityEndpoints();

app.Run();
