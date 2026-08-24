using System;
using System.Linq;
using System.Text.Json.Serialization;

namespace FormAppBlazorServer.Data
{
    public class Rootobjectcatalogue
    {
        [JsonPropertyName("themes")]
        public StageTheme[] themes { get; set; }
    }
}
