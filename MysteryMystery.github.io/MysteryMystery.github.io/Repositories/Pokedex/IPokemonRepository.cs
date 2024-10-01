using MysteryMystery.github.io.Models.Pokedex;

namespace MysteryMystery.github.io.Repositories.Pokedex
{
    public interface IPokemonRepository
    {
        public Task<ListResponse<NamedAPIResource>?> GetPokemonListAsync(int offset = 0, int limit = 9999);

        public Task<Pokemon?> GetPokemonAsync(string name);

        public Task<Pokemon?> GetPokemonAsync(int id);

        public Task<T> GetApiResource<T>(NamedAPIResource resource);

        public Task<T> GetApiResource<T>(APIResource resource);
    }
}
