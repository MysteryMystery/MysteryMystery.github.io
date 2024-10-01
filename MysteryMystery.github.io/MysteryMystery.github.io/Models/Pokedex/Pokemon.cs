using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public required int Id { get; set; }

        [JsonProperty("name")]
        public required string Name { get; set; }

        [JsonProperty("sprites")]
        public required PokemonSprite Sprites { get; set; }

        [JsonProperty("species")]
        public required NamedAPIResource Species { get; set; }

        [JsonProperty("abilities")]
        public required IEnumerable<PokemonAbility> Abilities { get; set; }

        [JsonProperty("types")]
        public required IEnumerable<PokemonType> Types { get; set; }
    }
}
