using System.Text.Json;
using Microsoft.Extensions.Caching.Memory;

namespace FormAppBlazorServer.Data;

public sealed class JsonDataLoader
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private readonly IWebHostEnvironment _environment;
    private readonly IMemoryCache _cache;

    public JsonDataLoader(IWebHostEnvironment environment, IMemoryCache cache)
    {
        _environment = environment;
        _cache = cache;
    }

    public async Task<T[]> LoadArrayAsync<T>(string relativePath, string cacheKey)
    {
        var cached = await _cache.GetOrCreateAsync(cacheKey, async entry =>
        {
            entry.SlidingExpiration = TimeSpan.FromMinutes(10);
            var path = Path.Combine(_environment.WebRootPath, relativePath);
            await using var stream = File.OpenRead(path);
            var data = await JsonSerializer.DeserializeAsync<T[]>(stream, SerializerOptions);
            return data ?? Array.Empty<T>();
        });

        return cached ?? Array.Empty<T>();
    }
}
