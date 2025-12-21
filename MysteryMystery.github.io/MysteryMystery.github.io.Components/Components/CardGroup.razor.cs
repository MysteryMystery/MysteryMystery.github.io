using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Components.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysteryMystery.github.io.Components.Components
{
    public partial class CardGroup : ComponentBase
    {
        [Parameter()]
        public List<Card> Cards { get; set; } = new();
    }
}
