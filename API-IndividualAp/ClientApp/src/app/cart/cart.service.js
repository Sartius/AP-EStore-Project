"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var CartService = /** @class */ (function () {
    function CartService() {
        this.cartItems = [];
    }
    CartService.prototype.getCartItems = function () {
        return this.cartItems.slice();
    };
    CartService.prototype.addItemToCart = function (item) {
        console.log("Call on cartService");
        console.log(this.cartItems);
        this.cartItems.push(item);
    };
    CartService = __decorate([
        core_1.Injectable()
    ], CartService);
    return CartService;
}());
exports.CartService = CartService;
//# sourceMappingURL=cart.service.js.map