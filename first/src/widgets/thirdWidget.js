import BaseWidget from "./baseWidget";

export default class ThirdWidget extends BaseWidget {
  createElement(id, callback) {
    const api = 'https://api.freecurrencyapi.com/v1/latest?apikey=fca_live_y5UWT7S2hmts92sMvRRHbswcO72g7wIZXDK1Mbgi&currencies=USD&base_currency=';
    const wrapper = super.createElement(id, callback);
    const select = document.createElement('select');
    const text = document.createElement('span');
    select.classList.add('apiSelect');
    text.classList.add('apiText');

    const getCurrencyData = async (currency) => {
      const answer = await fetch(api + currency);
      const result = await answer.json();
      text.innerHTML = 'Цена валюты в USD: ' + result.data.USD;
    }

    const currencies = ['AUD', 'RUB', 'PHP', 'CAD', 'JPY'];
    currencies.forEach((currency, i) => {
      const option = document.createElement('option');
      if (i === 0) option.selected = true;
      option.value = currency;
      option.innerHTML = currency;
      select.appendChild(option)
    });
    select.onchange = (e) => {
      getCurrencyData(currencies[e.currentTarget.selectedIndex]);
    }
    getCurrencyData(currencies[0]);
    wrapper.appendChild(select);
    wrapper.appendChild(text);
    return wrapper;
  }
}
