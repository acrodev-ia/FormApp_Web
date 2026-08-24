using System;
using System.Text.Json.Serialization;

namespace FormAppBlazorServer.Data
{
    public class Rootobjectplanning
    {
        [JsonPropertyName("items")]
        public ThemePlanning[] Themes { get; set; } = Array.Empty<ThemePlanning>();
    }

    public class ThemePlanning
    {
        [JsonPropertyName("theme")]
        public string ThemeLibelle { get; set; } = string.Empty;
        [JsonPropertyName("stage")]
        public StagePlanning[] Dates { get; set; } = Array.Empty<StagePlanning>();
    }

    public class StagePlanning
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [JsonPropertyName("idtheme")]
        public string IdTheme { get; set; } = string.Empty;
        [JsonPropertyName("texte")]
        public string Texte { get; set; } = string.Empty;
        [JsonPropertyName("date")]
        public string Date { get; set; } = string.Empty;
        [JsonPropertyName("lieu")]
        public string Lieu { get; set; } = string.Empty;
        [JsonPropertyName("nbplaces")]
        public int NbPlaces { get; set; }
        [JsonPropertyName("dureeprix")]
        public string DureePrix { get; set; } = string.Empty;
        [JsonPropertyName("intitule2")]
        public string Intitule2 { get; set; } = string.Empty;
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
        [JsonPropertyName("edof_objectif")]
        public string Edof_Objectif { get; set; } = string.Empty;
        [JsonPropertyName("edof_etatRecrutement")]
        public string Edof_EtatRecrutement { get; set; } = string.Empty;
        [JsonPropertyName("edof_parcours")]
        public string Edof_Parcours { get; set; } = string.Empty;
        [JsonPropertyName("edof_modaliteAdmission")]
        public string Edof_ModaliteAdmission { get; set; } = string.Empty;
        [JsonPropertyName("edof_langue")]
        public string Edof_Langue { get; set; } = string.Empty;
        [JsonPropertyName("edof_modaliteEnseignement")]
        public string Edof_ModaliteEnseignement { get; set; } = string.Empty;
        [JsonPropertyName("edof_modaliteEntreesSorties")]
        public string Edof_ModaliteEntreesSorties { get; set; } = string.Empty;
        [JsonPropertyName("edof_tauxTva")]
        public string Edof_TauxTva { get; set; } = string.Empty;
        [JsonPropertyName("edof_rythmeFormation")]
        public string Edof_RythmeFormation { get; set; } = string.Empty;
    }
}
