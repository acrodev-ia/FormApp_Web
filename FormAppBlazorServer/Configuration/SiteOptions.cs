namespace FormAppBlazorServer.Configuration;

public sealed class SiteOptions
{
    public const string SectionName = "MyApplicationConfiguration";

    public string MyTitle { get; set; } = "IG Formation";
    public string MyMail { get; set; } = "contact@igformation.fr";
    public string MyPhone { get; set; } = string.Empty;
    public string MyLogoSvg { get; set; } = "/iglogo.svg";
    public string AppUrl { get; set; } = "https://app.igformation.fr";
}
