using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MysteryMystery.github.io.Components.Abstract;

namespace MysteryMystery.github.io.Components.Button
{
    public partial class Button
    {
        [Parameter]
        public required RenderFragment ChildContent { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> HtmlAttributes { get; set; } = new();
    }
}
