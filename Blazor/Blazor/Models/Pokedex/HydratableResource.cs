using AutoMapper;
using Blazor.Services.Pokedex;
using System.Text.Json.Serialization;
using System.Xml;

namespace Blazor.Models.Pokedex
{
    public abstract class HydratableResource<T> where T : class
    {
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        public bool IsHydrated()
        {
            return this.GetType().GetProperties().Any(x => x.Name != "Url" && x.GetValue(this) != null);
        }

        public async Task<T> Hydrate(IPokeAPIService dataService) 
        {
            var r = await dataService.GetResource<T>(Url);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<T, T>());
            var mapper = config.CreateMapper();
            mapper.Map(r, this);

            return r;
        }
    }
}
