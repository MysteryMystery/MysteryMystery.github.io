using Microsoft.AspNetCore.Components;

namespace MysteryMystery.github.io.Layout.Components
{
    public partial class Footer : ComponentBase
    {
        [Inject]
        public IConfiguration Configuration { get; set; } = null!;

        private string GithubUrl { get; set; } = "";

        private string LinkedInUrl { get; set; } = "";

        protected override void OnInitialized()
        {
            GithubUrl = Configuration["Metadata:GitHubUrl"] ?? "";
            LinkedInUrl = Configuration["SocialMedia:LinkedInUrl"] ?? "";
        }
    }
}
