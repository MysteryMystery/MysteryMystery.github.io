using Blazor.Models;

namespace Blazor.Services
{
    public interface ICloutShootsService
    {
        /// <summary>
        /// Gets the valid years for clout shoots data
        /// </summary>
        /// <returns></returns>
        IEnumerable<int> GetYears();

        /// <summary>
        /// Get clout shoots for a year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        Task<IEnumerable<CloutShoot>> GetCloutShoots(int year);

        /// <summary>
        /// Gets this years clout shoots
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CloutShoot>> GetCurrentYearsCloutShoots();

        /// <summary>
        /// Gets the next clout shoots from <paramref name="currentYear"/> (will skip missing years)
        /// </summary>
        /// <param name="currentYear"></param>
        /// <returns></returns>
        Task<IEnumerable<CloutShoot>> GetNextCloutShoots(int currentYear);

        /// <summary>
        /// Gets the previous clout shoots from <paramref name="currentYear"/> (will skip missing years)
        /// </summary>
        /// <param name="currentYear"></param>
        /// <returns></returns>
        Task<IEnumerable<CloutShoot>> GetPreviousCloutShoots(int currentYear);
    }
}
