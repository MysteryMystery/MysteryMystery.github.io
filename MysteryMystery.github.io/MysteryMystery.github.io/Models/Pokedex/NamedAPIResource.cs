using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class NamedAPIResource
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
