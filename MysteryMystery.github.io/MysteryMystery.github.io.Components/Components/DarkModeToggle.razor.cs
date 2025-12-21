using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Services;

namespace MysteryMystery.github.io.Components.Components
{
    public partial class DarkModeToggle : ComponentBase, IDisposable
    {
        [Inject]
        public IDarkModeService DarkModeService { get; set; } = null!;

        private bool _isDarkMode;

        protected override async Task OnInitializedAsync()
        {
            await DarkModeService.InitializeAsync();
            _isDarkMode = await DarkModeService.IsDarkModeAsync();
            DarkModeService.OnChange += StateHasChanged;
        }

        private async Task ToggleDarkMode()
        {
            await DarkModeService.ToggleDarkModeAsync();
            _isDarkMode = await DarkModeService.IsDarkModeAsync();
        }

        public void Dispose()
        {
            DarkModeService.OnChange -= StateHasChanged;
        }
    }
}
