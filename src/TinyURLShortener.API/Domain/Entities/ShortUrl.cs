namespace TinyURLShortener.API.Domain.Entities;

public class ShortUrl
{
    public Guid Id { get; set; }
    
    public required string ShortCode { get; set; }

    public required string OriginalUrl { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime LastAccessedAt { get; set; }
}
