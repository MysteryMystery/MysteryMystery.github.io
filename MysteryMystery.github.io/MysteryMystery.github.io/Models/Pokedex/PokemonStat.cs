using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonStat
    {
        [JsonProperty("base_stat")]
        public required int BaseStat { get; set; }

        [JsonProperty("effort")]
        public required int Effort { get; set; }

        [JsonProperty("stat")]
        public required NamedAPIResource Stat { get; set; }
    }
}
