import Component from '@glimmer/component';
import { tracked } from '@glimmer/tracking';

export default class ThemedComponent extends Component {
  @tracked class = this.args.class || '';
  @tracked type = this.args.type || 'default';

  themes = {
    primary: 'bg-primary-light dark:bg-primary-dark text-white',
    secondary: 'bg-secondary-light dark:bg-secondary-dark text-dark dark:text-light',
    default: 'bg-white dark:bg-dark text-dark dark:text-light',
  };

  get classes() {
    let theme = this.themes[this.type] || '';

    return theme + ' ' + this.class;
  }
}
