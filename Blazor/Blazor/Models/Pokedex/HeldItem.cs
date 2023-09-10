#nullable enable
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8603

namespace Blazor.Models.Pokedex
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class HeldItem
    {
        [JsonPropertyName("item")]
        public UrlResource Item { get; set; }

        [JsonPropertyName("version_details")]
        public List<VersionDetail> VersionDetails { get; set; }
    }
}
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603
