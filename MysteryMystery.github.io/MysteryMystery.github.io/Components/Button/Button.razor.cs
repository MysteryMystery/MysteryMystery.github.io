using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Components.Abstract;

namespace MysteryMystery.github.io.Components.Button
{
    public partial class Button : AbstractThemedComponent
    {
        [Parameter]
        public required RenderFragment ChildContent { get; set; }
    }
}
