/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./**/*.{razor,html,cshtml,cs}"],
    theme: {
        extend: {
          colors: {
            dark: '#1D1E18',
            light: '#edf0ee',
    
            primary: {
              light: '#005377',
              dark: '#01344a',
            },
            secondary: {
              light: '#8EE3EF',
              dark: '#66a5ad',
            },
          },
        },
      },
    plugins: [],
}

