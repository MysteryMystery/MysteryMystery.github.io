using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonVersionedSprite
    {
        [JsonProperty("front_default")]
        public string? FrontDefault { get; set; }

        [JsonProperty("back_default")]
        public string? BackDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string? FrontShiny { get; set; }

        [JsonProperty("back_shiny")]
        public string? BackShiny { get; set; }
    }
}
