import { Component, OnInit, Input } from '@angular/core';
import { Item } from '../item/item.model';
import { CartService } from './cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css'],
  
})
export class CartComponent implements OnInit {
  @Input() cartItems: Item[] = [];

  constructor(private cartService: CartService) { }

    ngOnInit() {
        console.log("Getalovo?")
        console.log(this.cartItems)

    this.cartItems = this.cartService.getCartItems();
  }

}
