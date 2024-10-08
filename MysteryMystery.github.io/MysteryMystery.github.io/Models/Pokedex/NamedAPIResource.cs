﻿using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class NamedAPIResource
    {
        [JsonProperty("name")]
        public required string Name { get; set; }

        [JsonProperty("url")]
        public required string Url { get; set; }
    }
}
