using Microsoft.AspNetCore.Components;

namespace MysteryMystery.github.io.Components.Badge
{
    public partial class BadgeRow : ComponentBase
    {
        [Parameter]
        public required RenderFragment ChildContent { get; set; }
    }
}
