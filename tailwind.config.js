/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ['./app/**/*.{gjs,gts,hbs,html,js,ts}'],
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
};
