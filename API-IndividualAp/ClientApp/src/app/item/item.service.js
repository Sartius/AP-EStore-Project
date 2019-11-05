"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var item_model_1 = require("./item.model");
var core_1 = require("@angular/core");
var ItemService = /** @class */ (function () {
    function ItemService() {
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
    return ItemService;
}());
exports.ItemService = ItemService;
//# sourceMappingURL=item.service.js.map