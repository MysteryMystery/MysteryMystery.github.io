using Blazor.Models.Pokedex;

namespace Blazor.Services.Pokedex
{
    public interface IPokeAPIService
    {
        public Task<Pokemon> GetPokemonAsync(int id);
        public Task<Pokemon> GetPokemonAsync(string nameOrId);

        public Task<Pokemon[]> GetManyPokemonAsync(int offset, int limit=20);
        public Task<T> GetResource<T>(Uri url);
    }
}
