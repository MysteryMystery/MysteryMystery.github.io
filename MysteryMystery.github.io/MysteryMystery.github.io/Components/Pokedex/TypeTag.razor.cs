using Microsoft.AspNetCore.Components;
using MysteryMystery.github.io.Components.Abstract;

namespace MysteryMystery.github.io.Components.Pokedex
{
    public partial class TypeTag : AbstractThemedComponent
    {
        protected override Dictionary<string, string> Themes
        {
            get => new Dictionary<string, string>
                {
                    { "normal", "bg-gray-400 dark:bg-gray-600 text-gray-700 dark:text-gray-700 border-gray-700 dark:border-gray-700" },
                    { "fire", "bg-red-500 dark:bg-red-700 text-red-800 dark:text-red-800 border-red-800 dark:border-red-800" },
                    { "water", "bg-blue-500 dark:bg-blue-700 text-blue-800 dark:text-blue-800 border-blue-800 dark:border-blue-800" },
                    { "electric", "bg-yellow-500 dark:bg-yellow-700 text-yellow-800 dark:text-yellow-800 border-yellow-800 dark:border-yellow-800" },
                    { "grass", "bg-green-500 dark:bg-green-700 text-green-800 dark:text-green-800 border-green-800 dark:border-green-800" },
                    { "ice", "bg-blue-300 dark:bg-blue-500 text-blue-600 dark:text-blue-600 border-blue-600 dark:border-blue-600" },
                    { "fighting", "bg-red-700 dark:bg-red-900 text-red-900 dark:text-red-900 border-red-900 dark:border-red-900" },
                    { "poison", "bg-purple-500 dark:bg-purple-700 text-purple-800 dark:text-purple-800 border-purple-800 dark:border-purple-800" },
                    { "ground", "bg-yellow-700 dark:bg-yellow-900 text-yellow-900 dark:text-yellow-900 border-yellow-900 dark:border-yellow-900" },
                    { "flying", "bg-blue-300 dark:bg-blue-500 text-blue-600 dark:text-blue-600 border-blue-600 dark:border-blue-600" },
                    { "psychic", "bg-pink-500 dark:bg-pink-700 text-pink-800 dark:text-pink-800 border-pink-800 dark:border-pink-800" },
                    { "bug", "bg-green-600 dark:bg-green-900 text-green-900 dark:text-green-900 border-green-900 dark:border-green-900" },
                    { "rock", "bg-yellow-800 dark:bg-yellow-900 text-yellow dark:text-yellow-900 border-yellow-900 dark:border-yellow-900" },
                    { "ghost", "bg-purple-700 dark:bg-purple-900 text-purple dark:text-purple-900 border-purple-900 dark:border-purple-900" },
                    { "dragon", "bg-indigo-500 dark:bg-indigo-700 text-indigo-800 dark:text-indigo-800 border-indigo-800 dark:border-indigo-800" },
                    { "dark", "bg-gray-800 dark:bg-gray-900 text-gray dark:text-gray-900 border-gray-900 dark:border-gray-900" },
                    { "steel", "bg-gray-500 dark:bg-gray-700 text-gray-800 dark:text-gray-800 border-gray-800 dark:border-gray-800" },
                    { "fairy", "bg-pink-300 dark:bg-pink-500 text-pink-600 dark:text-pink-600 border-pink-600 dark:border-pink-600" }
                };
        }


        [Parameter]
        public required RenderFragment ChildContent { get; set; }
    }
}
