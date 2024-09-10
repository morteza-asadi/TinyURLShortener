using Microsoft.EntityFrameworkCore;
using TinyURLShortener.API.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("TinyUrlShortener"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();