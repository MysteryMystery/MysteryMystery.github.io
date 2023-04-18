/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./**/*.{razor,html,cshtml}"],
    theme: {
        extend: {
            colors: {
                "accent": "#fd1b7b",
                "hero": "#97DFFC",
                "primary": "#002969",
                "secondary": "#002866",
                "light": "#FFFFFF",

                "light-grey": "#e4e5e7",
                "deep-blue": "#000836",

                "ruby": "#E0115F",
                "csharp": "#9c75d5",
                "mysql": "#dd8a00",
                "php": "#7377ad",
                "java": "#507e9c"
            }
        },
    },
    plugins: [],
    safelist: [
        {
            pattern: /.+-(ruby|csharp|mysql|php|java|secondary|bg-primary|bg-transparent)/,
            variants: [], 
        },
        {
            pattern: /bg-(primary|transparent)/,
            variants: [],
        },
    ],
}
