using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TinyURLShortener.API.Domain.Entities;

namespace TinyURLShortener.API.Infrastructure.Persistence.Configurations;

public class ShortUrlConfiguration : IEntityTypeConfiguration<ShortUrl>
{
    public void Configure(EntityTypeBuilder<ShortUrl> builder)
    {
        builder.Property(p => p.Id)
            .ValueGeneratedOnAdd();

        builder.Property(p => p.ShortCode)
            .IsRequired()
            .HasMaxLength(8);

        builder.HasIndex(h => h.ShortCode)
            .IsUnique();

        builder.Property(p => p.OriginalUrl)
            .IsRequired()
            .HasMaxLength(2048);
    }
}