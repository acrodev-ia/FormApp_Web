using System;
using System.Text.Json.Serialization;

namespace FormAppBlazorServer.Data
{
    public class StageTheme
    {
        [JsonPropertyName("themelibelle")]
        public string ThemeLibelle { get; set; } = string.Empty;
        [JsonPropertyName("themeintitule")]
        public string ThemeIntitule { get; set; } = string.Empty;
        [JsonPropertyName("themebottom")]
        public string ThemeBottom { get; set; } = string.Empty;
        [JsonPropertyName("idtheme")]
        public string IdTheme { get; set; } = string.Empty;
        [JsonPropertyName("familles")]
        public StageFamille[] Familles { get; set; } = Array.Empty<StageFamille>();
    }
}
