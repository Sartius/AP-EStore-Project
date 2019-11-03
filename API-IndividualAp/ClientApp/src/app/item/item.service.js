"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var item_model_1 = require("./item.model");
var core_1 = require("@angular/core");
var ItemService = /** @class */ (function () {
    function ItemService() {
        this.addItem = new core_1.EventEmitter();
        this.items = [
            new item_model_1.Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 25),
            new item_model_1.Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 23),
            new item_model_1.Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 22),
            new item_model_1.Item('Car', 'Good Car', 'https://www.autocar.co.uk/sites/autocar.co.uk/files/styles/body-image/public/911-road-3629a.jpg?itok=m6x23Go0', 21)
        ];
    }
    ItemService.prototype.getItems = function () {
        return this.items.slice();
    };
    ItemService.prototype.onAddItems = function (item) {
        this.items.push(item);
    };
    return ItemService;
}());
exports.ItemService = ItemService;
//# sourceMappingURL=item.service.js.map