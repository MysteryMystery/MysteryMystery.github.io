using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Components.Abstract;

namespace MysteryMystery.github.io.Components.Badge
{
    public partial class Badge : AbstractThemedComponent
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}
