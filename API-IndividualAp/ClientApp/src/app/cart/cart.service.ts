import { Item } from "../item/item.model";
import { Injectable } from "@angular/core";


@Injectable()
export class CartService {
  private cartItems: Item[] = [];

  getCartItems() {
    return this.cartItems.slice();
  }

  addItemToCart(item: Item) {
    console.log("Call on cartService")
    console.log(this.cartItems)
    this.cartItems.push(item);
  }
}
