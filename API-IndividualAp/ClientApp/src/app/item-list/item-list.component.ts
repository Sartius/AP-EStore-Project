import { Component, OnInit } from '@angular/core';
import { Item } from '../item/item.model';
import { ItemService } from '../item/item.service';

@Component({
  selector: 'app-item-list',
  templateUrl: './item-list.component.html',
  styleUrls: ['./item-list.component.css'],
  providers: [ItemService]
})
export class ItemListComponent implements OnInit {
  item: Item;
  items: Item[];

  constructor(private itemService: ItemService) { }

  ngOnInit() {
    this.items = this.itemService.getItems();
    this.itemService.addItem.subscribe(this.item) => {
      itemService.onAddItem(item)
    };
  }
  onAddItems(item: Item) {
    this.items.push(item);
  }
}
