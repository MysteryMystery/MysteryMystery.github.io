using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Primitives;
using Microsoft.FeatureManagement;
using MysteryMystery.github.io.Models.Pokedex;
using MysteryMystery.github.io.Repositories.Pokedex;
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
        public IPokemonRepository PokemonRepository { get; set; }

        [Inject]
        public HttpClient HttpClient { get; set; }

        private ListResponse<NamedAPIResource>? _pokemonResponse = null;

        private List<Pokemon> _pokemon = new List<Pokemon>();

        protected override async Task OnInitializedAsync()
        {
            if(! await FeatureManager.IsEnabledAsync("enablePokedex")) {
                NavigationManager.NavigateTo("/404");
            }

            await base.OnInitializedAsync();

            _pokemonResponse = await PokemonRepository.GetPokemonListAsync();
            await LoadPokemonAsync();
        }

        public async Task LoadPokemonAsync(int offset = 0, int count = 25)
        {
            foreach (NamedAPIResource pokemon in _pokemonResponse.Results.Skip(offset).Take(count))
            {
                _ = Task.Run(async () =>
                {
                    Pokemon? p = await PokemonRepository.GetPokemonAsync(pokemon.Name);

                    if (p != null)
                    {
                        _pokemon.Add(p);
                    }

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
