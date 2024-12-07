using Microsoft.AspNetCore.Components;

namespace MysteryMystery.github.io.Components.Timeline
{
    public partial class TimeLine : ComponentBase
    {
        [Parameter]
        public required RenderFragment ChildContent { get; set; }
    }
}
