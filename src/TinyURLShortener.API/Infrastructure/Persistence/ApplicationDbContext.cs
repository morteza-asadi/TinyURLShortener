using Microsoft.EntityFrameworkCore;
using TinyURLShortener.API.Domain.Entities;

namespace TinyURLShortener.API.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<ShortUrl> ShortUrls { get; set; }
}