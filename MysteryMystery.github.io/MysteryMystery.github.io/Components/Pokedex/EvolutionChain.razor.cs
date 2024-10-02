using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Models.Pokedex;
using MysteryMystery.github.io.Repositories.Pokedex;

namespace MysteryMystery.github.io.Components.Pokedex
{
    public partial class EvolutionChain : ComponentBase
    {
        [Parameter]
        public required Pokemon Pokemon { get; set; }

        [Inject]
        public IPokemonRepository PokemonRepository { get; set; }

        [Inject]
        public ILogger<EvolutionChain> Logger { get; set; }

        private List<Pokemon?> _evolutionChain = new List<Pokemon?>();

        protected async override Task OnParametersSetAsync()
        {
            Logger.LogInformation($"{nameof(Pokemon)}: {Pokemon.Name}");

            _evolutionChain = await PopulateEvolutionChain();
        }

        private async Task<List<Pokemon?>> PopulateEvolutionChain()
        {
            List<Pokemon?> evoChain = new List<Pokemon?>();

            PokemonSpecies species = await PokemonRepository.GetApiResource<PokemonSpecies>(Pokemon.Species);
            PokemonEvolutionChain chain = await PokemonRepository.GetApiResource<PokemonEvolutionChain>(species.EvolutionChain);
            return await PopulateEvolutionChainLink(evoChain, chain.Chain);
        }

        private async Task<List<Pokemon?>> PopulateEvolutionChainLink(List<Pokemon?> chain, params PokemonEvolutionChainLink[] links)
        {
            foreach (var link in links)
            {
                PokemonSpecies species = await PokemonRepository.GetApiResource<PokemonSpecies>(link.Species);
                Pokemon? pokemon = Pokemon?.Id == species.Id ? Pokemon : await PokemonRepository.GetPokemonAsync(species.Id);
                chain.Add(pokemon);
                if (link.EvolvesTo == null)
                {
                    continue;
                }
                return await PopulateEvolutionChainLink(chain, link.EvolvesTo.ToArray());
            }
            return chain;
        }
    }
}
