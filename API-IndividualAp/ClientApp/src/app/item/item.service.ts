import { Item } from './item.model';
import { EventEmitter } from '@angular/core';

export class ItemService {
  addItem = new EventEmitter<Item>();

  private items: Item[] = [
    new Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 25),
    new Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 23),
    new Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 22),
    new Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 21)
  ];

  getItems() {
    return this.items.slice();
  }
  onAddItems(item: Item) {
    this.items.push(item);
  }
}
