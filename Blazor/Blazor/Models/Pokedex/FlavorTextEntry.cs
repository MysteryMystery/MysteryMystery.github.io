namespace Blazor.Models.Pokedex
{
    using System.Text.Json.Serialization;

    public partial class FlavorTextEntry
    {
        [JsonPropertyName("flavor_text")]
        public string FlavorText { get; set; }

        [JsonPropertyName("language")]
        public UrlResource Language { get; set; }

        [JsonPropertyName("version")]
        public UrlResource Version { get; set; }
    }
}