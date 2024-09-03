using Microsoft.AspNetCore.Components;

namespace MysteryMystery.github.io.Components.Badge
{
    public partial class BadgeRow : ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
