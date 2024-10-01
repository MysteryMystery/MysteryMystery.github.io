﻿using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonEvolutionChainLink
    {
        [JsonProperty("species")]
        public required NamedAPIResource Species {  get; set; }

        [JsonProperty("evolves_to")]
        public required IEnumerable<PokemonEvolutionChainLink> EvolvesTo { get; set; }
    }
}
