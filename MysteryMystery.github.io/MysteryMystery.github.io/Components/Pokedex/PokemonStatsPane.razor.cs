using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Models.Pokedex;

namespace MysteryMystery.github.io.Components.Pokedex
{
    public partial class PokemonStatsPane : ComponentBase
    {
        [Parameter]
        public required IEnumerable<PokemonStat> Stats { get; set; }

        private Dictionary<string, string> _statColours = new Dictionary<string, string>
        {
            { "hp", "#ff5959" },
            { "attack", "#f5ac78" },   
            { "defense", "#fae078" },
            { "special-attack", "#9db7f5" },
            { "special-defense", "#a7db8d" },
            { "speed", "#fa92b2" }
        };

        private double GetBaseStatPercentage(int baseStat) => (baseStat / 255.0) * 100;
    }
}
