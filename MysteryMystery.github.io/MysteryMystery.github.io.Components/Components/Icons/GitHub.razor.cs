using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysteryMystery.github.io.Components.Components.Icons
{
    public partial class GitHub : ComponentBase
    {
        [Parameter]
        public string Class { get; set; } = "";

        [Parameter]
        public string Fill { get; set; } = "";
    }
}
