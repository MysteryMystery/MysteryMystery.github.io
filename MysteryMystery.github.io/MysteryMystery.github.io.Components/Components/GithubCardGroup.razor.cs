using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MysteryMystery.github.io.Components.Helpers;

namespace MysteryMystery.github.io.Components.Components
{
    public partial class GithubCardGroup : ComponentBase
    {
        [Parameter()]
        public List<Models.GitHubCard> Cards { get; set; } = new();
    }
}
