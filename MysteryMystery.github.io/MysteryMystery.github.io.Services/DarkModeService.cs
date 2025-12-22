using Microsoft.JSInterop;
using MysteryMystery.github.io.Repositories;

namespace MysteryMystery.github.io.Services
{
    public enum ColourScheme
    {
        DARK,
        LIGHT
    }

    public class DarkModeService : IDarkModeService
    {
        private IBrowserStorageRepository _browserStorageRepository;
        private IJSRuntime _js;
        private readonly string _key = "theme";

        public DarkModeService(IBrowserStorageRepository browserStorageRepository, IJSRuntime js) {
            _browserStorageRepository = browserStorageRepository;    
            _js = js;
        }

        public async Task<ColourScheme> GetMode()
        {
            var theme = await _browserStorageRepository.GetItemAsync(_key);

            if (string.IsNullOrWhiteSpace(theme))
                return ColourScheme.LIGHT;

            if (Enum.TryParse(theme, ignoreCase: true, out ColourScheme scheme))
                return scheme;

            return ColourScheme.LIGHT;
        }

        public async Task SetMode(ColourScheme scheme) { 
            await _browserStorageRepository.SetItemAsync(_key, scheme.ToString());
            await ApplyThemeClasses();
        }

        public async Task ApplyThemeClasses()
        {
            var mode = await GetMode();
            await _js.InvokeVoidAsync("window.applyDarkMode", mode.ToString().ToLower());
        }
    }
}
