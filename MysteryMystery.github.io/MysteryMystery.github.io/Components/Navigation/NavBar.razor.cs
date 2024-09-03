﻿using System.ComponentModel.DataAnnotations;

namespace MysteryMystery.github.io.Components.Navigation
{
    public partial class NavBar 
    {
        private class Link
        {
            public string Display { get; set; }
            public string Url { get; set; }
        }

        private List<Link> _links = new List<Link>
        {
            new()
            {
                Display = "My Projects",
                Url = "#projects"
            },
            new()
            {
                Display = "My Education",
                Url = "#education"
            },
        };
    }
}
