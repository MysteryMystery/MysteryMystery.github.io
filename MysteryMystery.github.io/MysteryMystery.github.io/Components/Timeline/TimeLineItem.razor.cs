using Microsoft.AspNetCore.Components;

namespace MysteryMystery.github.io.Components.Timeline
{
    public partial class TimeLineItem : ComponentBase
    {
        [Parameter]
        public required RenderFragment Icon { get; set; }

        [Parameter]
        public required RenderFragment Title { get; set; }

        [Parameter]
        public RenderFragment? Description { get; set; }

        [Parameter]
        public DateOnly? Date { get; set; }
    }
}
