using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonAbility
    {
        [JsonProperty("ability")]
        public required NamedAPIResource Ability { get; set; }

        [JsonProperty("slot")]
        public required int Slot { get; set; }
    }
}
