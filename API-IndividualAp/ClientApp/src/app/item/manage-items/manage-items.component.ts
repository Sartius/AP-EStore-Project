import { Component, OnInit, ViewChild, ElementRef, EventEmitter, Output, Input } from '@angular/core';
import { Item } from '../item.model';
import { ItemService } from '../item.service';

@Component({
  selector: 'app-manage-items',
  templateUrl: './manage-items.component.html',
  styleUrls: ['./manage-items.component.css'],
  providers: [ItemService]
})
export class ManageItemsComponent implements OnInit {
  @Input() item: Item;
  
  @ViewChild('nameInput') nameInputRef: ElementRef;
  @ViewChild('descrInput') descrInputRef: ElementRef;
  @ViewChild('imgPathInput') imgPathInputRef: ElementRef;
  @ViewChild('priceInput') priceInputRef: ElementRef;

  //@Output() itemAdded = new EventEmitter< Item >();

  constructor(private itemService: ItemService) { }

  ngOnInit() {
  }

  onAddItem() {
    const itemName = this.nameInputRef.nativeElement.value;
    const itemDescr = this.descrInputRef.nativeElement.value;
    const itemImgPath = this.imgPathInputRef.nativeElement.value;
    const itemPrice = this.priceInputRef.nativeElement.value;
    this.item = new Item(itemName, itemDescr, itemImgPath, itemPrice);
    //this.itemAdded.emit(newItem);
    this.itemService.addItem.emit(this.item);
  }

}
