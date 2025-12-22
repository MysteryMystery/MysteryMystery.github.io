
namespace MysteryMystery.github.io.Repositories
{
    public interface IBrowserStorageRepository
    {
        Task ClearAsync();
        Task<T?> GetItemAsync<T>(string key);
        Task RemoveItemAsync(string key);
        Task SetItemAsync<T>(string key, T value);
    }
}