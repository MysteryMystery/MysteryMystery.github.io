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

        private void ToggleMobileMenu() => isMobileMenuOpen = !isMobileMenuOpen;
        private void CloseMobileMenu() => isMobileMenuOpen = false;
    }
}
