using System.Text.Json.Serialization;

namespace FormAppBlazorServer.Data
{
    public class StageDetail
    {
        [JsonPropertyName("id")]
        public string id { get; set; } = string.Empty;
        [JsonPropertyName("intitule")]
        public string Intitule { get; set; } = string.Empty;
        [JsonPropertyName("intitule2")]
        public string Intitule2 { get; set; } = string.Empty;
        [JsonPropertyName("objectif1")]
        public string Objectif1 { get; set; } = string.Empty;
        [JsonPropertyName("objectif2")]
        public string Objectif2 { get; set; } = string.Empty;
        [JsonPropertyName("objectif3")]
        public string Objectif3 { get; set; } = string.Empty;
        [JsonPropertyName("objectif4")]
        public string Objectif4 { get; set; } = string.Empty;
        [JsonPropertyName("prerequis")]
        public string Prerequis { get; set; } = string.Empty;
        [JsonPropertyName("evaluation")]
        public string Evaluation { get; set; } = string.Empty;
        [JsonPropertyName("pedagogie")]
        public string Pedagogie { get; set; } = string.Empty;
        [JsonPropertyName("publictype")]
        public string Publictype { get; set; } = string.Empty;
        [JsonPropertyName("resultat")]
        public string Resultat { get; set; } = string.Empty;
        [JsonPropertyName("dureeHeure")]
        public string DureeHeure { get; set; } = string.Empty;
        [JsonPropertyName("dureeJour")]
        public string DureeJour { get; set; } = string.Empty;
        [JsonPropertyName("dureeNote")]
        public string DureeNote { get; set; } = string.Empty;
        [JsonPropertyName("formateur")]
        public string Formateur { get; set; } = string.Empty;
        [JsonPropertyName("info")]
        public object Info { get; set; } = string.Empty;
        [JsonPropertyName("coutJour")]
        public string CoutJour { get; set; } = string.Empty;
        [JsonPropertyName("coutHeure")]
        public string CoutHeure { get; set; } = string.Empty;
        [JsonPropertyName("coutNote")]
        public string CoutNote { get; set; } = string.Empty;
        [JsonPropertyName("coutStagiaire")]
        public string CoutStagiaire { get; set; } = string.Empty;
        [JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
        [JsonPropertyName("contenu")]
        public string Contenu { get; set; } = string.Empty;
        [JsonPropertyName("nbPlacesMax")]
        public string NbPlacesMax { get; set; } = string.Empty;
    }
}
