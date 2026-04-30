using EndpointCrusader.BE.WebApi.Extensions;
using EndpointCrusader.BE.Application.IoC;
using EndpointCrusader.BE.DAL.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureApplicationServices();
builder.Services.ConfigureDALServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var api = app.MapGroup("/api");
api.AddEndpointConfigurationEndpoints();

app.Run();
