import { module, test } from 'qunit';
import { setupRenderingTest } from 'portfolio/tests/helpers';
import { render } from '@ember/test-helpers';
import { hbs } from 'ember-cli-htmlbars';

module('Integration | Component | card-footer', function (hooks) {
  setupRenderingTest(hooks);

  test('it renders', async function (assert) {
    // Set any properties with this.set('myProperty', 'value');
    // Handle any actions with this.set('myAction', function(val) { ... });

    await render(hbs`<CardFooter />`);

    assert.dom().hasText('');

    // Template block usage:
    await render(hbs`
      <CardFooter>
        template block text
      </CardFooter>
    `);

    assert.dom().hasText('template block text');
  });
});
