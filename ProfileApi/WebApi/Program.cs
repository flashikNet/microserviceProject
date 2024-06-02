using Domain;
using ExampleCore.HttpLogic;
using ExampleCore.TraceIdLogic;
using Infrastructure;
using Microsoft.Extensions.ObjectPool;
using ProfileConnectionLib.ConnectionServices.RabbitConnectionServer;
using RabbitMQ.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.TryAddTraceId();
builder.Services.AddHttpRequestService();
builder.Services.TryAddDomain();
builder.Services.TryAddInfrastructure();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ObjectPool<IConnection>>(serviceProvider =>
{
    return new DefaultObjectPool<IConnection>(new RabbitConnectionPool("localhost"), Environment.ProcessorCount * 2);
});

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
