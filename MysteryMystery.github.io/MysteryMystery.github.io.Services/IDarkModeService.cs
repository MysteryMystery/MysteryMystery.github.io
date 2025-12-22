namespace MysteryMystery.github.io.Services
{
    public interface IDarkModeService
    {
        Task SetMode(ColourScheme scheme);
        Task<ColourScheme> GetMode();
        Task ApplyThemeClasses();
    }
}
