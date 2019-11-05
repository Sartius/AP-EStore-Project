import { Component, OnInit,Input } from '@angular/core';
import { Item } from './item.model';
import { ItemService } from './item.service';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css'],
  //providers: [ItemService] Interesantno sto ovdje ne treba
})
export class ItemComponent implements OnInit {
  @Input() item: Item;

  constructor(private itemService: ItemService) { }

  ngOnInit() {

  }

  onAddToCart() {
    this.itemService.addItemToCart(this.item)
  }

}
