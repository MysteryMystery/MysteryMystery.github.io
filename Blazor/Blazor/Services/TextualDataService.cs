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
            var response = await _httpClient.GetAsync("data/hero-cards.json");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<HeroCard>>();
            }

            _logger.LogError("GetHeroCardsAsync - file not found");
            return new HeroCard[0];
        }

        public async Task<IEnumerable<ProjectShowcaseItem>> GetProjectShowcaseItemsAsync()
        {
            var response = await _httpClient.GetAsync("data/project-showcase-items.json");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<ProjectShowcaseItem>>();
            }

            _logger.LogError("GetProjectShowcaseItemsAsync - file not found");
            return new ProjectShowcaseItem[0];
        }

        public async Task<IEnumerable<ProjectShowcaseItem>> GetEducationShowcaseItemsAsync()
        {
            var response = await _httpClient.GetAsync("data/education-showcase-items.json");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<ProjectShowcaseItem>>();
            }

            _logger.LogError("GetEducationShowcaseItemsAsync - file not found");
            return new ProjectShowcaseItem[0];
        }

        public async Task<IEnumerable<ProjectShowcaseItem>> GetMiniProjectsShowcaseItemsAsync()
        {
            var response = await _httpClient.GetAsync("data/mini-projects.json");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<ProjectShowcaseItem>>();
            }

            _logger.LogError("GetMiniProjectsShowcaseItemsAsync - file not found");
            return new ProjectShowcaseItem[0];
        }
    }
}
