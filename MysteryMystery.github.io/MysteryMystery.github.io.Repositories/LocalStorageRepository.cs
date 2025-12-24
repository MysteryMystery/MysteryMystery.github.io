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

        public async Task SetItemAsync(string key, string value)
        {
            await _js.InvokeVoidAsync("localStorage.setItem", key, value);
        }

        public async Task<string> GetItemAsync(string key)
        {
            var str = await _js.InvokeAsync<string>("localStorage.getItem", key);
            return str;
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
