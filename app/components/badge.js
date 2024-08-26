import ThemedComponent from './themed-component';

export default class Badge extends ThemedComponent {
  themes = {
    red: '',
    ... this.themes,
  };
}
