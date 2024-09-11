using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonType
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("type")]
        public NamedAPIResource Type { get; set; }
    }
}
