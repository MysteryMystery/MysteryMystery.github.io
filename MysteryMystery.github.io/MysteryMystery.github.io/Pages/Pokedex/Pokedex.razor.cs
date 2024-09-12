using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Primitives;
using Microsoft.FeatureManagement;
using MysteryMystery.github.io.Models.Pokedex;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace MysteryMystery.github.io.Pages.Pokedex
{
    public partial class Pokedex : ComponentBase
    {
        [Inject]
        public IFeatureManager FeatureManager { get; set; }

        [Inject]
        public IConfiguration Configuration { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public HttpClient HttpClient { get; set; }

        private ListResponse<NamedAPIResource> _pokemonResponse = null;

        private List<Pokemon> _pokemon = new List<Pokemon>();

        protected override async Task OnInitializedAsync()
        {
            if(! await FeatureManager.IsEnabledAsync("enablePokedex")) {
                NavigationManager.NavigateTo("/404");
            }

            await base.OnInitializedAsync();

            await LoadPokemonAsync();
        }

        private async Task LoadPokemonAsync()
        {
            HttpResponseMessage response = await HttpClient.GetAsync(Configuration["PokeApiBaseUrl"] + "/pokemon");

            if(!response.IsSuccessStatusCode)
            {
                return;
            }

            string content = await response.Content.ReadAsStringAsync();
            _pokemonResponse = JsonConvert.DeserializeObject<ListResponse<NamedAPIResource>>(content)!;

            foreach (NamedAPIResource pokemon in _pokemonResponse.Results)
            {
                _ = Task.Run(async () =>
                {
                    HttpResponseMessage response = await HttpClient.GetAsync(pokemon.Url);
                    string content = await response.Content.ReadAsStringAsync();
                    Pokemon p = JsonConvert.DeserializeObject<Pokemon>(content)!;
                    _pokemon.Add(p);

                    _pokemon = _pokemon.OrderBy(p => p.Id).ToList();

                    StateHasChanged();
                });
            }
        }
    }
}
