import '../style.css'
import './styles/main.scss'
import WidgetManager from './widgetManager';

const columns = document.getElementsByClassName('column');
const select = document.getElementById('select');
const manager = new WidgetManager(columns);
const widgets = manager.getWidgets();
const button = document.getElementById('addWidget');
let selectedWidgetKey = null;
let draggable = null;

for (const column of columns) {
  column.addEventListener('dragstart', (e) => {
    draggable = e.target;
  });
  column.addEventListener('dragover', (e) => e.preventDefault());
  column.addEventListener('drop', () => {
    column.appendChild(draggable);
    draggable = null;
  });
}

select.innerHTML = '<option disabled selected>Выберите виджет</option>';
for (const item of widgets) {
  select.innerHTML += '<option value=' + item.key + '>' + item.title + '</option>';
}

select.addEventListener('change', (e) => {
  selectedWidgetKey = widgets[e.currentTarget.selectedIndex - 1].key;
});

button.addEventListener('click', () => {
  if (!selectedWidgetKey) return;
  manager.addWidgetInDom(selectedWidgetKey);
});
