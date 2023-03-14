using Blazor.Models;

namespace Blazor.Services
{
    public interface ITextualDataService
    {
        public Task<IEnumerable<HeroCard>> GetHeroCardsAsync();

        public Task<IEnumerable<ProjectShowcaseItem>> GetProjectShowcaseItemsAsync();
    }
}
