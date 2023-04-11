namespace Blazor.Models
{
    public class ProjectShowcaseItem
    {
        public string? Title { get; set; }
        public string? Body { get; set; }

        public string? ThumbnailUrl { get; set; }
        public string? WebsiteUrl { get; set; }

        public List<string> Tags { get; set; }
    }
}
