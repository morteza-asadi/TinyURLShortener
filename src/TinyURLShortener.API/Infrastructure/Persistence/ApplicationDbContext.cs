using Microsoft.EntityFrameworkCore;

namespace TinyURLShortener.API.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
}