"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var item_model_1 = require("./item.model");
var core_1 = require("@angular/core");
var ItemService = /** @class */ (function () {
    function ItemService(cartService) {
        this.cartService = cartService;
        //addItem = new EventEmitter<Item>();
        this.itemsChanged = new core_1.EventEmitter();
        this.array = [];
        this.items = [
            new item_model_1.Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 25),
            new item_model_1.Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 23),
            new item_model_1.Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 22),
            new item_model_1.Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 21)
        ];
    }
    ItemService.prototype.getItems = function () {
        console.log("On get Items:");
        console.log(this.items);
        console.log("Array:");
        console.log(this.array);
        return this.items;
    };
    ItemService.prototype.onAddItems = function (item) {
        console.log("what is inside the sent item?:");
        console.log(item);
        this.array.push(item);
        this.items.push(item);
        console.log(this.items);
        this.itemsChanged.emit(this.items.slice());
    };
    ItemService.prototype.addItemToCart = function (item) {
        console.log("Call on itemService to CartService");
        this.cartService.addItemToCart(item);
    };
    ItemService = __decorate([
        core_1.Injectable()
    ], ItemService);
    return ItemService;
}());
exports.ItemService = ItemService;
//# sourceMappingURL=item.service.js.map