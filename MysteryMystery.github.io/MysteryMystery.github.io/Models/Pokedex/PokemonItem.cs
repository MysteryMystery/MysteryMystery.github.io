using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonItemSprite
    {
        [JsonProperty("default")]
        public required string Default { get; set; }
    }

    public class PokemonItem
    {
        [JsonProperty("sprites")]
        public required PokemonItemSprite Sprites { get; set; }
    }
}
