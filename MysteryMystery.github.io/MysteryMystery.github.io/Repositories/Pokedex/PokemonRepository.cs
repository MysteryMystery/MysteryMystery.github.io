using MysteryMystery.github.io.Models.Pokedex;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MysteryMystery.github.io.Repositories.Pokedex
{
    public class PokemonRepository : IPokemonRepository
    {
        private HttpClient _httpClient;
        private string _pokeapiBaseUrl;

        public PokemonRepository(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _pokeapiBaseUrl = configuration["PokeApiBaseUrl"]!;
        }

        public async Task<Pokemon?> GetPokemonAsync(string name)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{_pokeapiBaseUrl}/pokemon/{name}");

            if (!response.IsSuccessStatusCode)
                return null;

            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Pokemon>(content);
        }

        public async Task<Pokemon?> GetPokemonAsync(int id)
        {
            return await GetPokemonAsync(id.ToString());
        }

        public async Task<ListResponse<NamedAPIResource>?> GetPokemonListAsync(int offset = 0, int limit = 9999)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{_pokeapiBaseUrl}/pokemon?offset={offset}&limit={limit}");

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ListResponse<NamedAPIResource>>(content)!;
        }

        public async Task<T> GetApiResource<T>(NamedAPIResource resource)
        {
            return await GetApiResource<T>(new APIResource() { Url = resource.Url });
        }

        public async Task<T> GetApiResource<T>(APIResource resource)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(resource.Url);

            if (!response.IsSuccessStatusCode)
            {
                return default(T)!;
            }

            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content)!;
        }
    }
}
