#nullable enable
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8603

namespace Blazor.Models.Pokedex
{
    using System.Text.Json.Serialization;

    public partial class VersionDetail
    {
        [JsonPropertyName("rarity")]
        public long Rarity { get; set; }

        [JsonPropertyName("version")]
        public UrlResource Version { get; set; }
    }
}
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603
