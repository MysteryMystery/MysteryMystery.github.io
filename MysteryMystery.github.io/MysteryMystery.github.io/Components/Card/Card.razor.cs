using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Components.Abstract;

namespace MysteryMystery.github.io.Components.Card
{
    public partial class Card : AbstractThemedComponent
    {
        [Parameter]
        public RenderFragment? Header { get; set; } = null!;

        [Parameter]
        public RenderFragment? Body { get; set; } = null!;

        [Parameter]
        public RenderFragment? Footer { get; set; } = null!;

        [Parameter]
        public bool EnableDivider { get; set; } = false;
    }
}
