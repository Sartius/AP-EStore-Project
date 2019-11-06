"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var CartService = /** @class */ (function () {
    function CartService() {
        this.cartItems = [];
    }
    CartService.prototype.getCartItems = function () {
        return this.cartItems.slice();
    };
    CartService.prototype.addItemToCart = function (item) {
        console.log("In cart service");
        this.cartItems.push(item);
        console.log(this.cartItems);
    };
    return CartService;
}());
exports.CartService = CartService;
//# sourceMappingURL=cart.service.js.map