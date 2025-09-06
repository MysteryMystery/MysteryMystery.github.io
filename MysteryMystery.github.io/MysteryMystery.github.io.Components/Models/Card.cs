using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysteryMystery.github.io.Components.Models
{
    public record Card(string Title, string Description, string? IconSvg = null, string? IconColor = null);
}
