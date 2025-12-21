using Microsoft.JSInterop;

namespace MysteryMystery.github.io.Services
{
    public class DarkModeService : IDarkModeService
    {
        private readonly IJSRuntime _jsRuntime;
        private bool _isDarkMode;

        public event Action? OnChange;

        public DarkModeService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task InitializeAsync()
        {
            _isDarkMode = await _jsRuntime.InvokeAsync<bool>("darkMode.initialize");
            OnChange?.Invoke();
        }

        public async Task ToggleDarkModeAsync()
        {
            _isDarkMode = await _jsRuntime.InvokeAsync<bool>("darkMode.toggle");
            OnChange?.Invoke();
        }

        public async Task<bool> IsDarkModeAsync()
        {
            return await Task.FromResult(_isDarkMode);
        }
    }
}
