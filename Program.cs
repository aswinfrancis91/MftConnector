using System.Net.Http.Headers;
using System.Text;
using ApiConnector;
using MftConnector.Interfaces;
using MftConnector.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMftClientFactory, MftClientFactory>();
builder.Services.AddHttpClient<GoAnywhereMftClient>(ClientConfigUtility.ConfigureClient);
builder.Services.AddHttpClient<MoveItMftClient>(ClientConfigUtility.ConfigureClient);
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

