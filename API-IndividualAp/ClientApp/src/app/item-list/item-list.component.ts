import { Component, OnInit } from '@angular/core';
import { Item } from '../item/item.model';
import { ItemService } from '../item/item.service';

@Component({
  selector: 'app-item-list',
  templateUrl: './item-list.component.html',
  styleUrls: ['./item-list.component.css'],

})
export class ItemListComponent implements OnInit {
  

  items: Item[];

  constructor(private itemService: ItemService) { }
  

  ngOnInit() {

    this.itemService.itemsChanged
      .subscribe(
        (items: Item[]) => {
          this.items = items;
        }
      );

    this.items = this.itemService.getItems();
    /*this.itemService.addItem.subscribe(this.item) => {
      itemService.onAddItem(item)
    };*/
    console.log("oninit");
    console.log(this.items);

  }
  onAddItems(item: Item) {
    console.log("ItemListComponent recieved the event");
    this.items.push(item);
    console.log(item);
  }
}
