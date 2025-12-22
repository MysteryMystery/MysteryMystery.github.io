namespace MysteryMystery.github.io.Services
{
    public interface IDarkModeService
    {
        Task SetScheme(ColourScheme scheme);
        Task<ColourScheme> GetScheme();
        Task ApplyThemeClasses();
    }
}
