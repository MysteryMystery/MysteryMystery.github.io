using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public required int Id { get; set; }

        [JsonProperty("name")]
        public required string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("sprites")]
        public PokemonSprite Sprites { get; set; }

        [JsonProperty("types")]
        public IEnumerable<PokemonType> Types { get; set; }
    }
}
