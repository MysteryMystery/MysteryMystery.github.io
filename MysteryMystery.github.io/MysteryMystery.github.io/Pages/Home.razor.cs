using Microsoft.AspNetCore.Components;
using Microsoft.FeatureManagement;

namespace MysteryMystery.github.io.Pages
{
    public partial class Home : ComponentBase
    {
        [Inject]
        public required IFeatureManager FeatureManager { get; set; }

        private bool IsPokedexEnabled { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            IsPokedexEnabled = await FeatureManager.IsEnabledAsync("enablePokedex");
            base.OnInitialized();
        }
    }
}
