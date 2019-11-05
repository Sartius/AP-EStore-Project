import { Item } from "../item/item.model";



export class CartService {
  private cartItems: Item[] = [];

  getCartItems() {
    return this.cartItems.slice();
  }

  addItemToCart(item: Item) {
    this.cartItems.push(item);
  }
}
