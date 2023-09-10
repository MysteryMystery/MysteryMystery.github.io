#nullable enable
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8603

namespace Blazor.Models.Pokedex
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public partial class Move
    {
        [JsonPropertyName("move")]
        public MoveDetails MoveDetails { get; set; }

        [JsonPropertyName("version_group_details")]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }

    public partial class MoveDetails : HydratableResource<MoveDetails>
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("power")]
        public int? Power { get; set; }

        [JsonPropertyName("pp")]
        public int PP { get; set; }

        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        [JsonPropertyName("flavor_text_entries")]
        public List<FlavorTextEntry> FlavorTextEntries { get; set;}

        [JsonPropertyName("type")]
        public Type Type { get; set; }
    }
}
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603
