/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./**/*.{razor,html,cshtml}"],
    theme: {
        extend: {
            colors: {
                "hero": "#eac251",
                "primary": "#44595e",
                "secondary": "#002866",
                "light": "#FFFFFF",
                "dark": "#34474d",
                "darker": "#2c3d44",

                "pale-yellow": "#fdfbe4",

                "light-grey": "#e2debb",

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
