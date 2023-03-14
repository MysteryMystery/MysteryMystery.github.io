/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./**/*.{razor,html,cshtml}"],
    theme: {
        extend: {
            colors: {
                "accent": "#fd1b7b",
                "hero": "#97DFFC",
                "secondary": "#002866",
                "light": "#FFFFFF",

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
            pattern: /.+-(ruby|csharp|mysql|php|java)/,
            variants: [],      // Optional
        },
    ],
}
