import { module, test } from 'qunit';
import { setupRenderingTest } from 'portfolio/tests/helpers';
import { render } from '@ember/test-helpers';
import { hbs } from 'ember-cli-htmlbars';

module('Integration | Component | badge-row', function (hooks) {
  setupRenderingTest(hooks);

  test('it renders', async function (assert) {
    // Set any properties with this.set('myProperty', 'value');
    // Handle any actions with this.set('myAction', function(val) { ... });

    await render(hbs`<BadgeRow />`);

    assert.dom().hasText('');

    // Template block usage:
    await render(hbs`
      <BadgeRow>
        template block text
      </BadgeRow>
    `);

    assert.dom().hasText('template block text');
  });
});
