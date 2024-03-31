import BaseWidget from "./baseWidget";

export default class FirstWidget extends BaseWidget {
  createElement(id, callback) {
    const wrapper = super.createElement(id, callback);
    const span = document.createElement('span');
    wrapper.appendChild(span);
    span.innerHTML = 'Виджет 1';
    return wrapper;
  }
}
