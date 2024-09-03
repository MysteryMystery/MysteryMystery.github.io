using Microsoft.AspNetCore.Components;

namespace MysteryMystery.github.io.Components.Abstract
{
    public partial class AbstractThemedComponent : ComponentBase
    {
        protected Dictionary<string, string> _themes = new Dictionary<string, string>
        {
            { "primary", "bg-primary-light dark:bg-primary-dark text-white" },
            { "secondary", "bg-secondary-light dark:bg-secondary-dark text-dark dark:text-light" },
            { "default", "bg-white dark:bg-dark text-dark dark:text-light" }
        };

        [Parameter]
        public string Class { get; set; } = "";

        [Parameter]
        public string Type { get; set; } = "default";

        public string Classes
        {
            get => (this._themes.ContainsKey(this.Type) ? this._themes[this.Type] : "") + " " + this.Class; 
        }
    }
}
