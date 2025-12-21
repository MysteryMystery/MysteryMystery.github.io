using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MysteryMystery.github.io.Components.Models.CaseStudy;

namespace MysteryMystery.github.io.Components.Components
{
    public partial class CaseStudy : ComponentBase
    {
        [Parameter]
        public MysteryMystery.github.io.Components.Models.CaseStudy.CaseStudy Study { get; set; } = null!;
    }
}
