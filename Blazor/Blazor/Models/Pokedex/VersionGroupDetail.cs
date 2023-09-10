#nullable enable
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8603

namespace Blazor.Models.Pokedex
{
    using System.Text.Json.Serialization;

    public partial class VersionGroupDetail : HydratableResource<VersionGroupDetail>
    {
        [JsonPropertyName("level_learned_at")]
        public long LevelLearnedAt { get; set; }

        [JsonPropertyName("move_learn_method")]
        public MoveLearnMethod MoveLearnMethod { get; set; }

        [JsonPropertyName("version_group")]
        public UrlResource VersionGroup { get; set; }
    }

    public partial class MoveLearnMethod : HydratableResource<MoveLearnMethod>
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
#pragma warning restore CS8618
#pragma warning restore CS8601
#pragma warning restore CS8603
