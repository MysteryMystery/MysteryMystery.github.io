

using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class ListResponse<T>
    {

        [JsonProperty("count")]
        public required int Count { get; set; }

        [JsonProperty("next")]
        public required string Next { get; set; }

        [JsonProperty("previous")]
        public required string Previous { get; set; }

        [JsonProperty("results")]
        public required IEnumerable<T> Results { get; set; }
    }
}
