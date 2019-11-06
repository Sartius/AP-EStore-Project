import { Item } from "../item/item.model";



export class CartService {
  private cartItems: Item[] = [];

  getCartItems() {
    return this.cartItems.slice();
  }

    addItemToCart(item: Item) {
      console.log("In cart service")
        this.cartItems.push(item);
      console.log(this.cartItems)
  }
}
