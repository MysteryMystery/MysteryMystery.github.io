using Microsoft.AspNetCore.Components;
using Microsoft.FeatureManagement;
using Microsoft.VisualBasic;
using MysteryMystery.github.io.Models.Pokedex;
using MysteryMystery.github.io.Repositories.Pokedex;
using Newtonsoft.Json;
using System.Text;

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
        public IPokemonRepository PokemonRepository { get; set; }

        [Parameter]
        public required string NameOrId { get; set; }

        private Pokemon? _pokemon { get; set; }

        private PokemonSpecies _species { get; set; }

        private ListResponse<NamedAPIResource>? _pokemonResponse = null;

        private bool _isLoading = true;

        protected override async Task OnInitializedAsync()
        {
            if (!await FeatureManager.IsEnabledAsync("enablePokedex"))
            {
                NavigationManager.NavigateTo("/404");
            }

            await base.OnInitializedAsync();
        }

        protected async override Task OnParametersSetAsync()
        {
            _isLoading = true;

            _pokemon = await PokemonRepository.GetPokemonAsync(NameOrId);

            if (_pokemon is null)
            {
                _pokemonResponse = await PokemonRepository.GetPokemonListAsync();
            } else
            {
                _species = await PokemonRepository.GetApiResource<PokemonSpecies>(_pokemon.Species);
            }

            _isLoading = false;
        }

        private IEnumerable<string> GetAllFrontDefaultSprites()
        {
            return new List<string?>()
            {
                _pokemon?.Sprites.Versions.GenerationI.RedBlue.FrontTransparent,
                _pokemon?.Sprites.Versions.GenerationII.Crystal.FrontTransparent,
                _pokemon?.Sprites.Versions.GenerationIII.FireRed.FrontDefault,
                _pokemon?.Sprites.Versions.GenerationIV.DiamondPearl.FrontDefault,
                _pokemon?.Sprites.Versions.GenerationV.BlackWhite.FrontDefault,
                _pokemon?.Sprites.Versions.GenerationVI.XY.FrontDefault,
                _pokemon?.Sprites.Versions.GenerationVII.SunMoon.FrontDefault
            }
            .Where(x => x != null)
            .Select(x => x!)
            .ToList();
        }

        private string NormaliseString(string s)
        {
            StringBuilder sb = new StringBuilder(s.Length);
            foreach (char c in s)
            {
                if ((int)c > 127)
                    continue;
                if ((int)c < 32) 
                    continue;
                if (c == '%')
                    continue;
                if (c == '?')
                    continue;
                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
