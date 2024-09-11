using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonSprite
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }
    }
}
