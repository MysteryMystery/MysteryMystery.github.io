using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
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

            await LoadPokemonSummaryAsync();
            await LoadPokemonAsync();
        }

        private async Task LoadPokemonSummaryAsync()
        {
            HttpResponseMessage response = await HttpClient.GetAsync(Configuration["PokeApiBaseUrl"] + "/pokemon?offset=0&limit=99999");

            if (!response.IsSuccessStatusCode)
            {
                return;
            }

            string content = await response.Content.ReadAsStringAsync();
            _pokemonResponse = JsonConvert.DeserializeObject<ListResponse<NamedAPIResource>>(content)!;
        }

        public async Task LoadPokemonAsync(int offset = 0, int count = 25)
        {
            foreach (NamedAPIResource pokemon in _pokemonResponse.Results.Skip(offset).Take(count))
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

        private async Task LoadMorePokemon(MouseEventArgs args)
        {
            var offset = _pokemon.Count();
            await LoadPokemonAsync(offset);
        }
    }
}
