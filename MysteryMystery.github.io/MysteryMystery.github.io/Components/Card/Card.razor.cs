using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Components.Abstract;

namespace MysteryMystery.github.io.Components.Card
{
    public partial class Card
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> HtmlAttributes { get; set; } = new();

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
