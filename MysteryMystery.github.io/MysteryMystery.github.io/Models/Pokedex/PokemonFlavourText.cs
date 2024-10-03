using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonFlavourText
    {
        [JsonProperty("flavor_text")]
        public required string FlavourText { get; set; }

        [JsonProperty("version")]
        public required NamedAPIResource Version { get; set; }

        [JsonProperty("language")]
        public required NamedAPIResource Language { get; set; }
    }
}
