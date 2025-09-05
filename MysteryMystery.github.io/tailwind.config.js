/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./**/*.{razor,html,cshtml,cs}"],
    safelist: [],
    theme: {
        extend: {
            colors: {
                brand: {
                    50: "#f5f7ff",
                    100: "#e7ecff",
                    200: "#c8d3ff",
                    300: "#a8baff",
                    400: "#7a93ff",
                    500: "#4c6cff",
                    600: "#3b55cc",
                    700: "#2b3e99",
                    800: "#1b2866",
                    900: "#0e163d"
                }
            },
            keyframes: {
                'gradient-move': {
                    '0%, 100%': { 'background-position': '0% 50%' },
                    '50%': { 'background-position': '100% 50%' },
                },
                'fade-in-up': {
                    '0%': { opacity: '0', transform: 'translateY(20px)' },
                    '100%': { opacity: '1', transform: 'translateY(0)' },
                },
                'fade-slide-down': {
                    '0%': { opacity: '0', transform: 'translateY(-10px)' },
                    '100%': { opacity: '1', transform: 'translateY(0)' },
                },

                'gradient-flow': {
                    '0%, 100%': { 'background-position': '0% 0%' },
                    '50%': { 'background-position': '100% 100%' },
                },
                'border-gradient': {
                    '0%': { 'background-position': '0% 50%' },
                    '100%': { 'background-position': '100% 50%' },
                }
            },
            animation: {
                'gradient-slow': 'gradient-move 12s ease infinite',
                'fade-in-up': 'fade-in-up 0.8s ease-out forwards',
                'fade-slide-down': 'fade-slide-down 0.3s ease-out forwards',
                'gradient-flow': 'gradient-flow 12s ease-in-out infinite',
                'border-gradient': 'border-gradient 3s linear infinite',

            },
            backgroundSize: {
                '200%': '200% 200%',
            }

        },
    },
    plugins: [],
}

