using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace MysteryMystery.github.io.Repositories
{
    public class JsonRepository : IJsonRepository
    {
        private readonly HttpClient _http;

        public JsonRepository(HttpClient http)
        {
            _http = http;
        }

        public async Task<T?> LoadAsync<T>(string path)
        {
            var json = await _http.GetStringAsync(path);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }

}
