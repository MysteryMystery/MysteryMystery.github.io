using Microsoft.AspNetCore.Components;
using Microsoft.FeatureManagement;

namespace MysteryMystery.github.io.Pages
{
    public partial class Home : ComponentBase
    {
        [Inject]
        public required IFeatureManager FeatureManager { get; set; }

        [Inject]
        public required IConfiguration Configuration { get; set; }

        private bool IsPokedexEnabled { get; set; } = false;

        private string _bloodfieldsUtilsUrl = string.Empty;
        private string _cloutShootsUrl = string.Empty;
        private string _pixelmcUrl = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            IsPokedexEnabled = await FeatureManager.IsEnabledAsync("enablePokedex");
            _bloodfieldsUtilsUrl = Configuration["BloodfieldsUtilsBaseUrl"]!;
            _cloutShootsUrl = Configuration["CloutShootsBaseUrl"]!;
            _pixelmcUrl = Configuration["PixelMCBaseUrl"]!;
            base.OnInitialized();
        }
    }
}
