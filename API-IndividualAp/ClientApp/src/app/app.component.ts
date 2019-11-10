import { Component } from '@angular/core';
import { ItemService } from './item/item.service';
import { CartService } from './cart/cart.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [ItemService,CartService]
})
export class AppComponent {
  title = 'app';
}
