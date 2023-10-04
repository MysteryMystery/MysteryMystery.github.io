namespace Blazor.Models.Pokedex
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;

    public partial class Species : HydratableResource<Species>
    {
        [JsonPropertyName("base_happiness")]
        public long? BaseHappiness { get; set; }

        [JsonPropertyName("capture_rate")]
        public long CaptureRate { get; set; }

        [JsonPropertyName("color")]
        public UrlResource Color { get; set; }

        [JsonPropertyName("egg_groups")]
        public List<UrlResource> EggGroups { get; set; }

        [JsonPropertyName("evolution_chain")]
        public EvolutionChain EvolutionChain { get; set; }

        [JsonPropertyName("evolves_from_species")]
        public UrlResource EvolvesFromSpecies { get; set; }

        [JsonPropertyName("flavor_text_entries")]
        public List<FlavorTextEntry> FlavorTextEntries { get; set; }

        [JsonPropertyName("form_descriptions")]
        public List<object> FormDescriptions { get; set; }

        [JsonPropertyName("forms_switchable")]
        public bool FormsSwitchable { get; set; }

        [JsonPropertyName("gender_rate")]
        public long GenderRate { get; set; }

        [JsonPropertyName("genera")]
        public List<Genus> Genera { get; set; }

        [JsonPropertyName("generation")]
        public UrlResource Generation { get; set; }

        [JsonPropertyName("growth_rate")]
        public UrlResource GrowthRate { get; set; }

        [JsonPropertyName("habitat")]
        public UrlResource Habitat { get; set; }

        [JsonPropertyName("has_gender_differences")]
        public bool HasGenderDifferences { get; set; }

        [JsonPropertyName("hatch_counter")]
        public long? HatchCounter { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("is_baby")]
        public bool IsBaby { get; set; }

        [JsonPropertyName("is_legendary")]
        public bool IsLegendary { get; set; }

        [JsonPropertyName("is_mythical")]
        public bool IsMythical { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }

        [JsonPropertyName("order")]
        public long Order { get; set; }

        [JsonPropertyName("pal_park_encounters")]
        public List<PalParkEncounter> PalParkEncounters { get; set; }

        [JsonPropertyName("pokedex_numbers")]
        public List<PokedexNumber> PokedexNumbers { get; set; }

        [JsonPropertyName("shape")]
        public UrlResource Shape { get; set; }

        [JsonPropertyName("varieties")]
        public List<Variety> Varieties { get; set; }
    }

    public partial class Genus
    {
        [JsonPropertyName("genus")]
        public string GenusGenus { get; set; }

        [JsonPropertyName("language")]
        public UrlResource Language { get; set; }
    }

    public partial class Name
    {
        [JsonPropertyName("language")]
        public UrlResource Language { get; set; }

        [JsonPropertyName("name")]
        public string NameName { get; set; }
    }

    public partial class PalParkEncounter
    {
        [JsonPropertyName("area")]
        public UrlResource Area { get; set; }

        [JsonPropertyName("base_score")]
        public long BaseScore { get; set; }

        [JsonPropertyName("rate")]
        public long Rate { get; set; }
    }

    public partial class PokedexNumber
    {
        [JsonPropertyName("entry_number")]
        public long EntryNumber { get; set; }

        [JsonPropertyName("pokedex")]
        public UrlResource Pokedex { get; set; }
    }

    public partial class Variety
    {
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("pokemon")]
        public Pokemon Pokemon { get; set; }
    }
}