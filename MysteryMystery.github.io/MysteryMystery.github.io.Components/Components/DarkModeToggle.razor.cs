using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Services;

namespace MysteryMystery.github.io.Components.Components
{
    public partial class DarkModeToggle : ComponentBase
    {
        [Inject]
        public IDarkModeService DarkModeService { get; set; } = null!;

        private bool _isDarkMode { get; set; } = false;
        private bool _isLoaded { get; set; } = false;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _isDarkMode = (await DarkModeService.GetMode()) == ColourScheme.DARK;
                _isLoaded = true;
                StateHasChanged();
            }
        }

        private async Task ToggleDarkMode()
        {
            _isDarkMode = !_isDarkMode;
            await DarkModeService.SetMode(_isDarkMode ? ColourScheme.DARK : ColourScheme.LIGHT);
        }
    }
}
