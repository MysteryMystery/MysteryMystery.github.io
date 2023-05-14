using System.Text.Json.Serialization;

namespace Blazor.Models
{
    public class CloutShoot
    {
        [JsonIgnore]
        public Guid Guid { get; set; }

        public string Name { get; set; }

        [JsonIgnore]
        public string NormalisedName { get => Name.Normalize(); }

        public DateTime Date { get; set; }

        public string? MapUrl { get; set; }

        public string? FormUrl { get; set; }

        public string? WhatThreeWords { get; set; }

        public string? ResultsUrl { get; set; }
    }
}
