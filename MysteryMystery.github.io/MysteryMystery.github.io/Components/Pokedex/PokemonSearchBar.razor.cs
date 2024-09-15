using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MysteryMystery.github.io.Models.Pokedex;
using MysteryMystery.github.io.Models.Pokedex.Form;
using System.Linq;

namespace MysteryMystery.github.io.Components.Pokedex
{
    public partial class PokemonSearchBar : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public IEnumerable<NamedAPIResource> Pokemon { get; set; }

        private PokemonSearchBarModel Model { get; set; } = new PokemonSearchBarModel();

        private IEnumerable<string> Suggestions { get; set; } = new List<string>();

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        private IEnumerable<string> SuggestResults()
        {
            return Pokemon.Where(x => x.Name.StartsWith(Model!.Name)).Select(x => x.Name);
        }

        private async Task OnNameInput(ChangeEventArgs args)
        {
            string searchText = (string?)args.Value ?? "";
            Model.Name = searchText.ToLower();

            if (Model.Name.Length == 0)
            {
                Suggestions = new List<string>();
                return;
            }

            Suggestions = SuggestResults().Order();
        }

        private async Task OnValidSubmit()
        {
            NavigationManager.NavigateTo("/pokemon/" + Model!.Name);
        }
    }
}
