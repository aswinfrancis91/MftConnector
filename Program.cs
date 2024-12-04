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
builder.Services.AddHttpClient<GoAnywhereMftClient>(client =>
{
    client.BaseAddress = new Uri("https://localhost:5001");
    const string user = "test";
    const string pass = "pass";
    var base64EncodedAuthenticationString = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{user}:{pass}"));
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
});
builder.Services.AddHttpClient<MoveItMftClient>(client => { client.BaseAddress = new Uri("https://localhost:5002"); });
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