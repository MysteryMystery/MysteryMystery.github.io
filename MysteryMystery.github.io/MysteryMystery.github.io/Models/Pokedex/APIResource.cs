using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class APIResource
    {
        [JsonProperty("url")]
        public required string Url { get; set; }
    }
}
