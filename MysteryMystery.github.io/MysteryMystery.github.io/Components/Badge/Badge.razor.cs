using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Components.Abstract;

namespace MysteryMystery.github.io.Components.Badge
{
    public partial class Badge
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> HtmlAttributes { get; set; } = new();
    }
}
