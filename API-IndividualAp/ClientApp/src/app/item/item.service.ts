import { Item } from './item.model';
import { EventEmitter, Injectable } from '@angular/core';
import { CartService } from '../cart/cart.service';

@Injectable()

export class ItemService {
  //addItem = new EventEmitter<Item>();
  itemsChanged = new EventEmitter<Item[]>();
  public array: Item[] = [];

  public items: Item[] = [
    new Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 25),
    new Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 23),
    new Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 22),
    new Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 21)
  ];

  constructor(private cartService: CartService) {}

  getItems() {
    console.log("On get Items:");
    console.log(this.items);
    console.log("Array:");
    console.log(this.array);
    return this.items;
  }
  onAddItems(item: Item) {
    console.log("what is inside the sent item?:");
    console.log(item);
    this.array.push(item);
    this.items.push(item);
    console.log(this.items);
    this.itemsChanged.emit(this.items.slice());
  }
    addItemToCart(item: Item) {
        console.log("Service.addtocart")
        console.log(item)
    this.cartService.addItemToCart(item);
  }
}
