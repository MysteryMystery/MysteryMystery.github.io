using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonSpecies
    {
        [JsonProperty("id")]
        public required int Id { get; set; }

        [JsonProperty("name")]
        public required String Name { get; set; }

        [JsonProperty("evolution_chain")]
        public required APIResource EvolutionChain { get; set; }

        [JsonProperty("flavor_text_entries")]
        public required IEnumerable<PokemonFlavourText> FlavourTextEntries { get; set; }
    }
}
