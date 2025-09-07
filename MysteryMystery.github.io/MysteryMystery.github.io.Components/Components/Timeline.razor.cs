using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysteryMystery.github.io.Components.Components
{
    public partial class Timeline : ComponentBase
    {
        [Parameter]
        public List<TimelineItem> Items { get; set; } = new List<TimelineItem>();
    }
}
