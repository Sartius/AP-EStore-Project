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
        this.cartItems.push(item);
    };
    return CartService;
}());
exports.CartService = CartService;
//# sourceMappingURL=cart.service.js.map