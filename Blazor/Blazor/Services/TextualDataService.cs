using Blazor.Models;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Json;

namespace Blazor.Services
{
    public class TextualDataService : ITextualDataService
    {
        private HttpClient _httpClient;
        private ILogger<TextualDataService> _logger;

        public TextualDataService(HttpClient httpClient, ILogger<TextualDataService> logger) { 
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<IEnumerable<HeroCard>> GetHeroCardsAsync()
        {
            string file = "data/hero-cards.json";
            var response = await _httpClient.GetAsync("data/hero-cards.json");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<HeroCard>>();
            }

            _logger.LogError("GetHeroCardsAsync - file not found");
            return new HeroCard[0];
        }
    }
}
