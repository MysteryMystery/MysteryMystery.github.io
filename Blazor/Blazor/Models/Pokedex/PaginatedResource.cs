namespace Blazor.Models.Pokedex
{
    public class PaginatedResource
    {
        public int Count { get; set; }
        public Uri? Next { get; set; }
        public Uri? Previous { get; set; }
        public List<UrlResource> Results { get; set; }
    }
}
