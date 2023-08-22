using Blazor.Services.Catan;
using Blazor.Services;
using Blazor.Services.Pokedex;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blazor.Models.Pokedex;

namespace Blazor.Pokedex.Tests
{
    internal class PokemonTests
    {

        private IPokeAPIService _pokeAPIService;
        private ILogger<PokeAPIService> _logger;
        private HttpClient _httpClient;

        [SetUp]
        public void Setup()
        {
            string baseUrl = "https://pokeapi.co/api/v2";
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddHttpClient()
                .AddScoped<IPokeAPIService, PokeAPIService>(x => new PokeAPIService(
                        baseUrl, 
                        x.GetRequiredService<ILogger<PokeAPIService>>(),
                        x.GetRequiredService<HttpClient>()
                    ))
                .BuildServiceProvider();
            var factory = serviceProvider.GetService<ILoggerFactory>();

            _logger = factory.CreateLogger<PokeAPIService>();
            _pokeAPIService = serviceProvider.GetRequiredService<IPokeAPIService>();
            _httpClient = serviceProvider.GetRequiredService<HttpClient>();
        }

        [Test]
        [TestCase(25)]
        public void Pokemon_ShouldBe_RetrievedAndSerialized(int id)
        {
            Pokemon p = _pokeAPIService.GetPokemonAsync(id).Result;
            Assert.Pass();
        }

        [Test]
        [TestCase("pikachu")]
        public void Pokemon_ShouldBe_RetrievedAndSerialized(string id)
        {
            Pokemon p = _pokeAPIService.GetPokemonAsync(id).Result;
            Assert.Pass();
        }
    }
}
