using EncurtadorURLs.Data;
using EncurtadorURLs.Models;

namespace EncurtadorURLs.Services;

public interface IUrlsService
{
    Task<UrlItem> CreateShortUrlAsync(string originalUrl);
    Task<UrlItem?> GetUrlByIdAsync(Guid id); // Adicionado no Exercício 2
}

public class UrlsService : IUrlsService
{
    private readonly IUrlContext _context;

    public UrlsService(IUrlContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public Task<UrlItem> CreateShortUrlAsync(string originalUrl)
    {
        throw new NotImplementedException();
    }

    // Stub adicionado para o Exercício 2 (Fase RED)
    public Task<UrlItem?> GetUrlByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}