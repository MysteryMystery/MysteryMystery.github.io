namespace Blazor.Models.Pokedex
{
    using System;
    using System.Collections.Generic;

    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Globalization;

    public partial class EvolutionChain : HydratableResource<EvolutionChain>
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("baby_trigger_item")]
        public object BabyTriggerItem { get; set; }

        [JsonPropertyName("chain")]
        public Chain Chain { get; set; }
    }

    public partial class Chain
    {
        [JsonPropertyName("is_baby")]
        public bool IsBaby { get; set; }

        [JsonPropertyName("species")]
        public Species Species { get; set; }

        [JsonPropertyName("evolution_details")]
        public object EvolutionDetails { get; set; }

        [JsonPropertyName("evolves_to")]
        public List<Chain> EvolvesTo { get; set; }
    }

    public partial class EvolutionDetail
    {
        [JsonPropertyName("item")]
        public object Item { get; set; }

        [JsonPropertyName("trigger")]
        public Species Trigger { get; set; }

        [JsonPropertyName("gender")]
        public object Gender { get; set; }

        [JsonPropertyName("held_item")]
        public object HeldItem { get; set; }

        [JsonPropertyName("known_move")]
        public object KnownMove { get; set; }

        [JsonPropertyName("known_move_type")]
        public object KnownMoveType { get; set; }

        [JsonPropertyName("location")]
        public object Location { get; set; }

        [JsonPropertyName("min_level")]
        public long MinLevel { get; set; }

        [JsonPropertyName("min_happiness")]
        public object MinHappiness { get; set; }

        [JsonPropertyName("min_beauty")]
        public object MinBeauty { get; set; }

        [JsonPropertyName("min_affection")]
        public object MinAffection { get; set; }

        [JsonPropertyName("needs_overworld_rain")]
        public bool NeedsOverworldRain { get; set; }

        [JsonPropertyName("party_species")]
        public object PartySpecies { get; set; }

        [JsonPropertyName("party_type")]
        public object PartyType { get; set; }

        [JsonPropertyName("relative_physical_stats")]
        public object RelativePhysicalStats { get; set; }

        [JsonPropertyName("time_of_day")]
        public string TimeOfDay { get; set; }

        [JsonPropertyName("trade_species")]
        public object TradeSpecies { get; set; }

        [JsonPropertyName("turn_upside_down")]
        public bool TurnUpsideDown { get; set; }
    }
}