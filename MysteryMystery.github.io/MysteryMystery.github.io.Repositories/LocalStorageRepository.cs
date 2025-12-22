using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace MysteryMystery.github.io.Repositories
{
    public class LocalStorageRepository : IBrowserStorageRepository
    {
        private readonly IJSRuntime _js;

        public LocalStorageRepository(IJSRuntime js)
        {
            _js = js;
        }

        public async Task SetItemAsync<T>(string key, T value)
        {
            var json = JsonConvert.SerializeObject(value);
            await _js.InvokeVoidAsync("localStorage.setItem", key, json);
        }

        public async Task<T?> GetItemAsync<T>(string key)
        {
            var json = await _js.InvokeAsync<string>("localStorage.getItem", key);

            if (string.IsNullOrWhiteSpace(json))
                return default;

            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task RemoveItemAsync(string key)
        {
            await _js.InvokeVoidAsync("localStorage.removeItem", key);
        }

        public async Task ClearAsync()
        {
            await _js.InvokeVoidAsync("localStorage.clear");
        }
    }
}
