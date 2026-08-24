namespace FormAppBlazorServer.Data;

public sealed class CatalogueService
{
    private const string CacheKey = "catalogue-full";
    private readonly JsonDataLoader _loader;

    public CatalogueService(JsonDataLoader loader)
    {
        _loader = loader;
    }

    public async Task<IReadOnlyList<Rootobjectcatalogue>> GetCatalogueAsync()
        => await _loader.LoadArrayAsync<Rootobjectcatalogue>(Path.Combine("datas", "cataloguefull.json"), CacheKey);

    public async Task<IReadOnlyList<StageTheme>> GetThemesAsync()
    {
        var catalogues = await GetCatalogueAsync();
        return catalogues
            .SelectMany(catalogue => catalogue.themes ?? Array.Empty<StageTheme>())
            .ToList();
    }

    public async Task<CourseRecord?> FindCourseAsync(string? courseId)
    {
        if (string.IsNullOrWhiteSpace(courseId))
        {
            return null;
        }

        foreach (var theme in await GetThemesAsync())
        {
            foreach (var famille in theme.Familles ?? Array.Empty<StageFamille>())
            {
                foreach (var stage in famille.Stages ?? Array.Empty<StageDetail>())
                {
                    if (string.Equals(stage.id, courseId, StringComparison.OrdinalIgnoreCase))
                    {
                        return new CourseRecord(theme, famille, stage);
                    }
                }
            }
        }

        return null;
    }

    public async Task<IReadOnlyList<CourseRecord>> SearchAsync(string? query)
    {
        if (string.IsNullOrWhiteSpace(query))
        {
            return Array.Empty<CourseRecord>();
        }

        var needle = query.Trim();
        var results = new List<CourseRecord>();

        foreach (var theme in await GetThemesAsync())
        {
            foreach (var famille in theme.Familles ?? Array.Empty<StageFamille>())
            {
                foreach (var stage in famille.Stages ?? Array.Empty<StageDetail>())
                {
                    if (Contains(stage.Intitule, needle)
                        || Contains(stage.Intitule2, needle)
                        || Contains(stage.Code, needle))
                    {
                        results.Add(new CourseRecord(theme, famille, stage));
                    }
                }
            }
        }

        return results;
    }

    private static bool Contains(string? haystack, string needle)
        => !string.IsNullOrEmpty(haystack)
           && haystack.Contains(needle, StringComparison.OrdinalIgnoreCase);
}
