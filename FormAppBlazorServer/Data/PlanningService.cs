namespace FormAppBlazorServer.Data;

#nullable enable
public sealed class PlanningService
{
    private const string CacheKey = "planning";
    private readonly JsonDataLoader _loader;

    public PlanningService(JsonDataLoader loader)
    {
        _loader = loader;
    }

    /// <summary>API historique utilisée par les pages Razor.</summary>
    public async Task<IEnumerable<Rootobjectplanning>> GetPlanningAsync()
        => await _loader.LoadArrayAsync<Rootobjectplanning>(Path.Combine("datas", "planning.json"), CacheKey);

    public async Task<IReadOnlyList<StagePlanning>> GetSessionsForCourseAsync(string? courseId)
    {
        if (string.IsNullOrWhiteSpace(courseId))
        {
            return Array.Empty<StagePlanning>();
        }

        var plannings = await GetPlanningAsync();
        return plannings
            .SelectMany(planning => planning.Themes ?? Array.Empty<ThemePlanning>())
            .SelectMany(theme => theme.Dates ?? Array.Empty<StagePlanning>())
            .Where(session => string.Equals(session.Id, courseId, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}
