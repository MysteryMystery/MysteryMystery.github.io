using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel.DataAnnotations;

namespace MysteryMystery.github.io.Components.Navigation
{
    public partial class NavBar 
    {
        private class Link
        {
            public required string Display { get; set; }
            public required string Url { get; set; }
        }

        private List<Link> _links = new List<Link>
        {
            new()
            {
                Display = "My Projects",
                Url = "/#projects"
            },
            new()
            {
                Display = "My Education",
                Url = "/#education"
            },
        };

        private bool _isMobileCollapsed = true;

        private async Task ToggleNav(MouseEventArgs args)
        {
            _isMobileCollapsed = !_isMobileCollapsed;
        }
    }
}
