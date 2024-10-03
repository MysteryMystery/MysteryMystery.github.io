using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonEvolutionDetails
    {
        [JsonProperty("min_level")]
        public int? MinLevel { get; set; }

        [JsonProperty("time_of_day")]
        public string? TimeOfDay { get; set; }

        [JsonProperty("trigger")]
        public required NamedAPIResource Trigger { get; set; }
    }
}
