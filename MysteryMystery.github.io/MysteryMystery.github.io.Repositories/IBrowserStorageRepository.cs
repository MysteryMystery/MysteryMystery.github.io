
namespace MysteryMystery.github.io.Repositories
{
    public interface IBrowserStorageRepository
    {
        Task ClearAsync();
        Task<string> GetItemAsync(string key);
        Task RemoveItemAsync(string key);
        Task SetItemAsync(string key, string value);
    }
}