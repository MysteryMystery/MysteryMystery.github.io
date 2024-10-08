﻿using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class PokemonSprite
    {
        public class Other
        {
            [JsonProperty("official-artwork")]
            public required OfficialArtwork OfficialArtwork { get; set; }
        }

        public class OfficialArtwork
        {
            [JsonProperty("front_default")]
            public required string FrontDefault { get; set; }
        }

        [JsonProperty("front_default")]
        public required string FrontDefault { get; set; }

        [JsonProperty("back_default")]
        public required string BackDefault { get; set; }

        [JsonProperty("front_shiny")]
        public required string FrontShiny { get; set; }

        [JsonProperty("back_shiny")]
        public required string BackShiny { get; set; }

        [JsonProperty("other")]
        public required Other OtherSprites { get; set; }

        [JsonProperty("versions")]
        public PokemonSpriteVersions Versions { get; set; }
    }
}
