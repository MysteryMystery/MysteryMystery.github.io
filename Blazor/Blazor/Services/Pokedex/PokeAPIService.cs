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
            return await _httpClient.GetFromJsonAsync<Pokemon>($"{_baseUrl}/pokemon/{nameOrId}");
        }
    }
}
