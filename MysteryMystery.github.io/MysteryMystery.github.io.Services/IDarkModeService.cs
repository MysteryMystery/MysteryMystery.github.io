namespace MysteryMystery.github.io.Services
{
    public interface IDarkModeService
    {
        Task InitializeAsync();
        Task ToggleDarkModeAsync();
        Task<bool> IsDarkModeAsync();
        event Action? OnChange;
    }
}
