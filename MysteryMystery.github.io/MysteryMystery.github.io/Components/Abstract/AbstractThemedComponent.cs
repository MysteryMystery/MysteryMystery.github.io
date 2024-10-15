using Microsoft.AspNetCore.Components;

namespace MysteryMystery.github.io.Components.Abstract
{
    [Obsolete("Moving towards scoped css rules.")]
    public abstract partial class AbstractThemedComponent : ComponentBase
    {
        protected virtual Dictionary<string, string> Themes { get; set; } = new Dictionary<string, string>();

        private Dictionary<string, string> _defaultThemes = new Dictionary<string, string>
        {
            { "primary", "bg-primary-light dark:bg-primary-dark text-white" },
            { "secondary", "bg-secondary-light dark:bg-secondary-dark text-dark dark:text-light" },
            { "default", "bg-white dark:bg-dark text-dark dark:text-light" }
        };

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> HtmlAttributes { get; set; } = new();

        [Parameter]
        public string Type { get; set; } = "default";

        public string Classes
        {
            get
            {
                string classes = HtmlAttributes.ContainsKey("class") ? HtmlAttributes["class"].ToString()! : "";

                if (this.Themes.ContainsKey(Type))
                {
                    classes += " " + this.Themes[Type];
                }
                else if(this._defaultThemes.ContainsKey(Type))
                {
                    classes += " " + this._defaultThemes[Type];
                }

                return classes;
            }
        }
    }
}
