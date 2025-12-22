using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Services;

namespace MysteryMystery.github.io.Components.Components
{
    public partial class DarkModeToggle : ComponentBase
    {
        [Inject]
        public IDarkModeService DarkModeService { get; set; } = null!;

        private bool _isDarkMode { get; set; } = false;

        private async Task ToggleDarkMode()
        {
            _isDarkMode = !_isDarkMode;
            await DarkModeService.SetMode(_isDarkMode ? ColourScheme.DARK : ColourScheme.LIGHT);
        }
    }
}
