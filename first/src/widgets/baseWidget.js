export default class BaseWidget {
  wrapper;

  constructor() {
    this.wrapper = document.createElement('div');
    this.wrapper.classList.add('widget');
    this.wrapper.draggable = true;
  }

  createElement(id, callback) {
    this.wrapper.dataset.id = id;
    const button = document.createElement('button');
    button.innerHTML = 'X';
    button.classList.add('widgetRemove');
    this.wrapper.appendChild(button);
    button.addEventListener('click', callback);
    return this.wrapper;
  }
}
