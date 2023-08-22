using Blazor.Models.Pokedex;

namespace Blazor.Services.Pokedex
{
    public interface IPokeAPIService
    {
        public Task<Pokemon> GetPokemonAsync(int id);
        public Task<Pokemon> GetPokemonAsync(string nameOrId);
    }
}
