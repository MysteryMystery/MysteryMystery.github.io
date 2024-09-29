/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./**/*.{razor,html,cshtml,cs}"],
    safelist: [
        {
            pattern: /bg-pokemon-.*/,
        }
    ],
    theme: {
        extend: {
            colors: {
                darker: '#1D1E18',
                dark: "#39393A",
                light: '#edf0ee',

                primary: {
                    light: '#005377',
                    dark: '#01344a',
                },
                secondary: {
                    light: '#83B5D1',
                    dark: '#618499',
                },
                pokemon: {
                    normal: '#a0a0a0',
                    fire: '#ff4500',
                    water: '#0074d9',
                    electric: '#ffdc00',
                    grass: '#4caf50',
                    ice: '#b3e0ff',
                    fighting: '#d32f2f',
                    poison: '#9c27b0',
                    ground: '#795548',
                    flying: '#03a9f4',
                    psychic: '#e91e63',
                    bug: '#8bc34a',
                    rock: '#9e9e9e',
                    ghost: '#673ab7',
                    dark: '#212121',
                    steel: '#607d8b',
                    fairy: '#ff80ab',
                    dragon: '#ff5722',
                }
            },
        },
    },
    plugins: [],
}

