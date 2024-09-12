using Microsoft.AspNetCore.Components;
using Microsoft.FeatureManagement;
using MysteryMystery.github.io.Models.Pokedex;
using Newtonsoft.Json;

namespace MysteryMystery.github.io.Pages.Pokedex
{
    public partial class PokemonShow : ComponentBase
    {

        [Inject]
        public IFeatureManager FeatureManager { get; set; }

        [Inject]
        public IConfiguration Configuration { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public HttpClient HttpClient { get; set; }

        [Parameter]
        public required string NameOrId { get; set; }

        private Pokemon _pokemon { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (!await FeatureManager.IsEnabledAsync("enablePokedex"))
            {
                NavigationManager.NavigateTo("/404");
            }

            await base.OnInitializedAsync();

            await LoadPokemonAsync();
        }

        private async Task LoadPokemonAsync()
        {
            HttpResponseMessage response = await HttpClient.GetAsync(Configuration["PokeApiBaseUrl"] + "/pokemon/" + NameOrId);

            if (!response.IsSuccessStatusCode)
            {
                return;
            }

            string content = await response.Content.ReadAsStringAsync();
            _pokemon = JsonConvert.DeserializeObject<Pokemon>(content)!;
        }
    }
}
