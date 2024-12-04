using System.Net.Http.Headers;
using System.Text;
using MftConnector.Interfaces;
using MftConnector.Models;
using MftConnector.Models.Service;
using MftConnector.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMftClientFactory, MftClientFactory>();
builder.Services.AddHttpClient<GoAnywhereMftClient>(httpClient => ClientConfigUtility.ConfigureClient(httpClient, MftClient.GoAnywhere));
builder.Services.AddHttpClient<MoveItMftClient>(httpClient => ClientConfigUtility.ConfigureClient(httpClient, MftClient.MoveIt));
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