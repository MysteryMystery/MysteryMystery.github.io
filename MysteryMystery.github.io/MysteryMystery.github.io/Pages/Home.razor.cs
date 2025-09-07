using Microsoft.VisualBasic;
using MysteryMystery.github.io.Components.Components;
using MysteryMystery.github.io.Components.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Repositories;
using MysteryMystery.github.io.Components.Helpers;

namespace MysteryMystery.github.io.Pages
{
    public partial class Home : ComponentBase
    {
        [Inject]
        public IConfiguration Configuration { get; set; } = null!;

        [Inject]
        public IJsonRepository Repository { get; set; } = null!;

        private List<Card> Skills = new();
        private List<Card> Projects = new();
        private List<GitHubCard> GitHubProjects = new();
        private List<TimelineItem> Timeline = new();
        private List<Fact> Facts = new();
        private Components.Models.CaseStudy.CaseStudy CaseStudy = null!;

        private SectionIndex SectionIndex = new();

        protected override async Task OnInitializedAsync()
        {
            SectionIndex.Reset();

            Skills = await Repository.LoadAsync<List<Card>>("data/skills.json") ?? new();
            Projects = await Repository.LoadAsync<List<Card>>("data/projects.json") ?? new();
            GitHubProjects = await Repository.LoadAsync<List<GitHubCard>>("data/github-projects.json") ?? new();
            Timeline = await Repository.LoadAsync<List<TimelineItem>>("data/timeline.json") ?? new();
            Facts = await Repository.LoadAsync<List<Fact>>("data/facts.json") ?? new();
            CaseStudy = await Repository.LoadAsync<Components.Models.CaseStudy.CaseStudy>("data/case-study.json") ?? null!;
        }
    }
}
