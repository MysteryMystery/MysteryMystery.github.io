using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Models.Pokedex;
using MysteryMystery.github.io.Repositories.Pokedex;

namespace MysteryMystery.github.io.Components.Pokedex
{
    public partial class EvolutionChain : ComponentBase
    {

        private class ChainLinkViewModel
        {
            public Pokemon? Pokemon { get; set; }

            public PokemonEvolutionDetails? EvolutionDetails { get; set; }
        }

        [Parameter]
        public required Pokemon Pokemon { get; set; }

        [Inject]
        public IPokemonRepository PokemonRepository { get; set; }

        [Inject]
        public ILogger<EvolutionChain> Logger { get; set; }

        private List<ChainLinkViewModel?> _evolutionChain = new List<ChainLinkViewModel?>();

        protected async override Task OnParametersSetAsync()
        {
            Logger.LogInformation($"{nameof(Pokemon)}: {Pokemon.Name}");

            _evolutionChain = await PopulateEvolutionChain();
        }

        private async Task<List<ChainLinkViewModel?>> PopulateEvolutionChain()
        {
            List<ChainLinkViewModel?> evoChain = new List<ChainLinkViewModel?>();

            PokemonSpecies species = await PokemonRepository.GetApiResource<PokemonSpecies>(Pokemon.Species);
            PokemonEvolutionChain chain = await PokemonRepository.GetApiResource<PokemonEvolutionChain>(species.EvolutionChain);
            return await PopulateEvolutionChainLink(evoChain, chain.Chain);
        }

        private async Task<List<ChainLinkViewModel?>> PopulateEvolutionChainLink(List<ChainLinkViewModel?> chain, params PokemonEvolutionChainLink[] links)
        {
            foreach (PokemonEvolutionChainLink link in links)
            {
                PokemonSpecies species = await PokemonRepository.GetApiResource<PokemonSpecies>(link.Species);
                Pokemon? pokemon = Pokemon?.Id == species.Id ? Pokemon : await PokemonRepository.GetPokemonAsync(species.Id);
                if (pokemon != null)
                {
                    chain.Add(new()
                    {
                        Pokemon = pokemon,
                        EvolutionDetails = link.EvolutionDetails.FirstOrDefault()
                    });
                }

                if (link.EvolvesTo == null)
                {
                    continue;
                }

                await PopulateEvolutionChainLink(chain, link.EvolvesTo.ToArray());
            }
            return chain;
        }
    }
}
