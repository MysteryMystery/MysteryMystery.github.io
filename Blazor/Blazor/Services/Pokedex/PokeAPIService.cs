using Blazor.Models.Pokedex;
using System.Net.Http.Json;
using System.Text.Json;

namespace Blazor.Services.Pokedex
{
    public class PokeAPIService : IPokeAPIService
    {
        private readonly ILogger _logger;
        private readonly string _baseUrl;
        private readonly HttpClient _httpClient;

        public PokeAPIService(string baseUrl, ILogger<PokeAPIService> logger, HttpClient httpClient)
        {
            _baseUrl = baseUrl;
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<Pokemon> GetPokemonAsync(int id)
        {
            return await GetPokemonAsync(id.ToString());
        }
        

        public async Task<Pokemon> GetPokemonAsync(string nameOrId)
        {
            return await GetResource<Pokemon>(new Uri($"{_baseUrl}/pokemon/{nameOrId}"));
        }

        public async Task<Pokemon[]> GetManyPokemonAsync(int offset=0, int limit = 20)
        {
            PaginatedResource result = await _httpClient.GetFromJsonAsync<PaginatedResource>($"{_baseUrl}/pokemon?offset={offset}&limit={limit}");
            List<Pokemon> pokemons = new List<Pokemon>();

            // sadly we have to do these one at a time otherwise blazor will throw an error due to multi threading            
            foreach(var r in result.Results)
            {
                pokemons.Add(await GetPokemonAsync(r.Name));
            }

            return pokemons.ToArray();
        }

        public async Task<T> GetResource<T>(Uri url)
        {
            //_logger.LogInformation($"Getting: {url.ToString()}");
            //_logger.LogInformation(await _httpClient.GetStringAsync(url));
            return await _httpClient.GetFromJsonAsync<T>(url);
        }
    }
}
