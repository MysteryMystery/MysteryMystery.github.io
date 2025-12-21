using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysteryMystery.github.io.Components.Models
{
    public record GitHubCard(
        string Name,
        string Description,
        string RepoUrl,
        string? LiveUrl,
        List<TechTag>? Tech = null
    );

    public record TechTag(
        string Language,
        List<string>? Frameworks = null
    );
}
