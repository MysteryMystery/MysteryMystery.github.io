using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonSpecies
    {
        [JsonProperty("evolution_chain")]
        public required APIResource EvolutionChain { get; set; }

        [JsonProperty("name")]
        public required String Name { get; set; }

        [JsonProperty("id")]
        public required int Id { get; set; }
    }
}
