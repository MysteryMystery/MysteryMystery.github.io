using Newtonsoft.Json;

namespace MysteryMystery.github.io.Models.Pokedex
{
    public class GenerationI
    {
        [JsonProperty("red-blue")]
        public required PokemonVersionedSprite RedBlue { get; set; }
    }

    public class GenerationII
    {
        [JsonProperty("crystal")]
        public required PokemonVersionedSprite Crystal { get; set; }
    }

    public class GenerationIII
    {
        [JsonProperty("emerald")]
        public required PokemonVersionedSprite Emerald { get; set; }

        [JsonProperty("firered-leafgreen")]
        public required PokemonVersionedSprite FireRed { get; set; }
    }

    public class GenerationIV
    {
        [JsonProperty("diamond-pearl")]
        public required PokemonVersionedSprite DiamondPearl { get; set; }
    }

    public class GenerationV
    {
        [JsonProperty("black-white")]
        public required PokemonVersionedSprite BlackWhite { get; set; }
    }

    public class GenerationVI
    {
        [JsonProperty("x-y")]
        public required PokemonVersionedSprite XY { get; set; }
    }

    public class GenerationVII
    {
        [JsonProperty("ultra-sun-ultra-moon")]
        public required PokemonVersionedSprite SunMoon { get; set; }
    }

    public class PokemonSpriteVersions
    {
        [JsonProperty("generation-i")]
        public required GenerationI GenerationI { get; set; }

        [JsonProperty("generation-ii")]
        public required GenerationII GenerationII { get; set; }

        [JsonProperty("generation-iii")]
        public required GenerationIII GenerationIII { get; set; }

        [JsonProperty("generation-iv")]
        public required GenerationIV GenerationIV { get; set; }

        [JsonProperty("generation-v")]
        public required GenerationV GenerationV { get; set; }

        [JsonProperty("generation-vi")]
        public required GenerationVI GenerationVI { get; set; }

        [JsonProperty("generation-vii")]
        public required GenerationVII GenerationVII { get; set; }
    }
}
