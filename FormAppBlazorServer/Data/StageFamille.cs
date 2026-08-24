using System;
using System.Text.Json.Serialization;

namespace FormAppBlazorServer.Data
{
    public class StageFamille
    {
        [JsonPropertyName("famillelibelle")]
        public string FamilleLibelle { get; set; } = string.Empty;
        [JsonPropertyName("idfamille")]
        public string IdFamille { get; set; } = string.Empty;
        [JsonPropertyName("stages")]
        public StageDetail[] Stages { get; set; } = Array.Empty<StageDetail>();
    }
}
