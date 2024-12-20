using Microsoft.AspNetCore.Components;
using Microsoft.FeatureManagement;
using Microsoft.JSInterop;

namespace MysteryMystery.github.io.Pages
{
    public partial class Home : ComponentBase, IAsyncDisposable
    {
        [Inject]
        public required IFeatureManager FeatureManager { get; set; }

        [Inject]
        public required IConfiguration Configuration { get; set; }

        [Inject]
        public required IJSRuntime JSRuntime { get; set; }
        private IJSObjectReference? _jsModule;

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

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./Pages/Home.razor.js");
                await _jsModule.InvokeVoidAsync("initializeScrollEffect");
            }
        }



        async ValueTask IAsyncDisposable.DisposeAsync()
        {
            if (_jsModule is not null)
            {
                try
                {
                    await _jsModule.DisposeAsync();
                }
                catch (JSDisconnectedException)
                {
                }
            }
        }
    }
}
