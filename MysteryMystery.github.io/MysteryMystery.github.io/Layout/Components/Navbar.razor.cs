using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using MysteryMystery.github.io.Components.Models.Options;

namespace MysteryMystery.github.io.Layout.Components
{
    public partial class Navbar : ComponentBase
    {
        private record NavLink(string Href, string Label);

        [Inject]
        public IOptions<FeatureFlagOptions> FeatureFlags { get; set; } = null!;

        private bool isMobileMenuOpen;

        private List<NavLink> NavLinks { get; set; } = new List<NavLink>();

        private void ToggleMobileMenu() => isMobileMenuOpen = !isMobileMenuOpen;
        private void CloseMobileMenu() => isMobileMenuOpen = false;

        protected override async Task OnInitializedAsync()
        {
            NavLinks = new List<NavLink>
                {
                    new NavLink("/", "Home"),
                    new NavLink("#skills", "Skills"),
                    new NavLink("#projects", "Projects"),
                    new NavLink("#journey", "My Journey")
                };

            if (FeatureFlags.Value.EnableGitHubShowCase)
            {
                NavLinks.Add(new NavLink("#github-projects", "Github Projects"));
            }
        }
    }
}
