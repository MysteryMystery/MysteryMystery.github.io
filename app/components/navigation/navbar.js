import Component from '@glimmer/component';
import { tracked } from '@glimmer/tracking';

export default class NavigationNavbar extends Component {
  @tracked links = [
    {
      display: 'My Projects',
      href: '#projects',
    },
    {
      display: 'My Education',
      href: '#eduction',
    },
  ];
}
