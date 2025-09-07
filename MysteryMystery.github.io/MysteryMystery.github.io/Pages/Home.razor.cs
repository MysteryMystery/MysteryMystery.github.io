using Microsoft.VisualBasic;
using MysteryMystery.github.io.Components.Components;
using MysteryMystery.github.io.Components.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.AspNetCore.Components;

namespace MysteryMystery.github.io.Pages
{
    public partial class Home : ComponentBase
    {
        [Inject]
        public IConfiguration Configuration { get; set; } = null!;

        private readonly List<Card> Skills = new()
        {
            new Card("Azure architecture", "Landing zones, PaaS-first, cost governance, identity with Entra ID.", null, "#4c6cff"),
            new Card("Infrastructure as Code", "Terraform modules, policy-as-code, drift detection, environment parity.", null, "#ff6cab"),
            new Card("CI/CD & reliability", "Azure Pipelines, gated releases, canary/blue‑green, observability & SLOs.", null, "#ffc95e"),
            new Card(".NET Development", "Blazor WebAssembly, Web APIs, Azure Functions, and App Services for scalable, cloud‑native solutions.", null, "#4c6cff"),
            new Card("Team support & stakeholder management", "Mentoring engineers, facilitating cross‑team collaboration, and translating technical detail into clear, actionable updates for stakeholders.", null, "#ff6cab")
        };

        private readonly List<Card> Projects = new()
        {
            new Card("Company-wide Azure landing zone",
                "Standardised networking, identity, and guardrails. Reduced incident load by 40%.",
                // Heroicon: Building Office
                "<svg xmlns='http://www.w3.org/2000/svg' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M3 21h18M9 21V9h6v12M9 9V3h6v6'/></svg>",
                "#4c6cff"),

            new Card("PaaS modernization",
                "Migrated legacy services to App Service & Functions. Lowered costs by 25%.",
                // Heroicon: Cloud
                "<svg xmlns='http://www.w3.org/2000/svg' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M3 15a4 4 0 014-4h1a5 5 0 019.9-1.5A4.5 4.5 0 0120 19H7a4 4 0 01-4-4z'/></svg>",
                "#ff6cab"),

            new Card("Implementing security scanning in Azure Pipelines",
                "Integrated Veracode, Checkov, and TFLint into CI/CD to enforce security and compliance early.",
                // Heroicon: Shield Check
                "<svg xmlns='http://www.w3.org/2000/svg' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M12 3l8.485 4.243a2 2 0 01.879 2.379l-3.03 9.09a2 2 0 01-1.9 1.288H7.566a2 2 0 01-1.9-1.288l-3.03-9.09a2 2 0 01.879-2.379L12 3z'/><path stroke-linecap='round' stroke-linejoin='round' d='M9 12l2 2 4-4'/></svg>",
                "#ffc95e"),

            new Card("Azure announcements RSS reader",
                "Built an RSS reader to surface Azure announcements and EOL alerts directly to the team.",
                // Heroicon: Rss
                "<svg xmlns='http://www.w3.org/2000/svg' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M4 4a16 16 0 0116 16M4 11a9 9 0 019 9M6 18a2 2 0 11-4 0 2 2 0 014 0z'/></svg>",
                "#4c6cff"),

            new Card("Terraform best practices & automation",
                "Implemented reusable modules, policy-as-code, and automated drift detection to improve reliability.",
                // Heroicon: Cog
                "<svg xmlns='http://www.w3.org/2000/svg' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M10.325 4.317c.426-1.756 2.924-1.756 3.35 0a1.724 1.724 0 002.573 1.066c1.543-.89 3.31.877 2.42 2.42a1.724 1.724 0 001.065 2.573c1.756.426 1.756 2.924 0 3.35a1.724 1.724 0 00-1.065 2.573c.89 1.543-.877 3.31-2.42 2.42a1.724 1.724 0 00-2.573 1.065c-.426 1.756-2.924 1.756-3.35 0a1.724 1.724 0 00-2.573-1.065c-1.543.89-3.31-.877-2.42-2.42a1.724 1.724 0 00-1.065-2.573c-1.756-.426-1.756-2.924 0-3.35a1.724 1.724 0 001.065-2.573c-.89-1.543.877-3.31 2.42-2.42.996.574 2.247.574 3.243 0z'/><path stroke-linecap='round' stroke-linejoin='round' d='M15 12a3 3 0 11-6 0 3 3 0 016 0z'/></svg>",
                "#ff6cab")
        };

        private readonly List<TimelineItem> Timeline = new()
        {
            new("2015", "Started my career as a Developer", "Built and maintained web applications, learning the foundations of clean code and scalable design.", "#4c6cff"),
            new("2016–2018", "Created side projects", "Explored new tech stacks, automated personal workflows, and experimented with cloud hosting.", "#ff6cab"),
            new("2019", "Became a DevOps Engineer", "Shifted focus to infrastructure-as-code, CI/CD pipelines, and cloud-native operations.", "#ffc95e"),
            new("2020", "Defined company-wide standards", "Architected and documented infrastructure patterns, security baselines, and deployment processes.", "#4c6cff"),
            new("2021", "Helped with recruitment", "Interviewed candidates, assessed technical skills, and shaped hiring criteria for engineering roles.", "#ff6cab"),
            new("2022", "Upskilled the team", "Ran workshops, created documentation, and mentored engineers to improve cloud and automation skills.", "#ffc95e"),
            new("2023–Present", "Led on-prem to cloud migration", "Took ownership of a full-scale migration, ensuring minimal downtime and long-term scalability.", "#4c6cff")
        };

        private readonly List<GitHubCard> GitHubProjects = new()
        {
            new("Azure Landing Zone Templates",
                "Terraform modules and policies for enterprise‑grade Azure landing zones.",
                "https://github.com/yourusername/azure-landing-zone",
                null,
                new()
                {
                    new("Terraform"),
                    new("Azure Pipelines")
                }),

            new("PaaS Modernization Toolkit",
                "Scripts and IaC for migrating legacy workloads to Azure App Service & Functions.",
                "https://github.com/yourusername/paas-modernization",
                "https://modernization-demo.yoursite.com",
                 new List<TechTag>
                {
                    new("C#", new(){ "Azure Functions" }),
                    new("Terraform"),
                    new("Docker")
                }),

            new("Azure Announcements RSS Reader",
                "RSS reader that surfaces Azure announcements and EOL alerts to Teams.",
                "https://github.com/yourusername/azure-announcements-rss",
                null, 
                new List<TechTag>
                {
                    new("C#", new(){ "Azure Functions" }),
                    new("Terraform")
                })
        };

        private readonly List<Fact> Facts = new()
        {
            new("8+ years", "in DevOps & Cloud"),
            new("Azure Certified", "Platform & Security"),
            new("40% reduction", "in incident load")
        };

        private readonly MysteryMystery.github.io.Components.Models.CaseStudy.CaseStudy CaseStudy = new(
            "On‑Prem to Cloud Migration Expertise",
            "Led the end‑to‑end migration of critical workloads — including Big Data processing pipelines and high‑availability financial systems — from on‑premises data centres to Azure.\r\n            Ensured minimal downtime, regulatory compliance, and long‑term scalability.",
            new List<string>
            {
                "Architected hybrid connectivity and identity integration for secure, compliant financial operations.",
                "Optimised Big Data ingestion and processing pipelines for cloud‑native scalability and cost efficiency.",
                "Reduced operational overhead by 35% through PaaS adoption and CI/CD automation."
            }
        );
    }
}
