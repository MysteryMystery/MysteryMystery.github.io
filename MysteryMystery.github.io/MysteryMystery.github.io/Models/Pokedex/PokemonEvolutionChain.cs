

using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonEvolutionChain
    {
        [JsonProperty("chain")]
        public required PokemonEvolutionChainLink Chain { get; set; }
    }
}
