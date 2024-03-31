import FirstWidget from './widgets/firstWidget';
import SecondWidget from './widgets/secondWidget';
import ThirdWidget from './widgets/thirdWidget';

export default class WidgetManager {
  widgets = [];
  columns = [];
  addedWidgets = [];

  constructor(columns) {
    this.columns = columns;
    this.widgets = [
      { title: 'Первый виджет', key: 'key1', widget: FirstWidget },
      { title: 'Второй виджет', key: 'key2', widget: SecondWidget },
      { title: 'Третий виджет', key: 'key3', widget: ThirdWidget },
    ];
  }

  removeWidgetFromDom(id) {
    const element = document.querySelector(`[data-id="${id}"]`);
    if (element) {
      element.remove();
    }
  }

  getWidgets() {
    return this.widgets;
  }

  addWidgetInDom(key) {
    const widget = this.widgets.find(_widget => _widget.key === key);
    if (!widget) return;
    const id = 'id-' + Math.round(Math.random() * 10000);
    const newWidget = new widget.widget().createElement(id, () => this.removeWidgetFromDom(id));
    this.columns[0].appendChild(newWidget);
  }
}
