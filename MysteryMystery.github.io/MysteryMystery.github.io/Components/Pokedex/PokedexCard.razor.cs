using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Components.Abstract;
using MysteryMystery.github.io.Models.Pokedex;

namespace MysteryMystery.github.io.Components.Pokedex
{
    public partial class PokedexCard : AbstractThemedComponent
    {
        [Parameter]
        public required Pokemon Pokemon { get; set; }
    }
}
