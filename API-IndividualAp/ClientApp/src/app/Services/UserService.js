"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var UserService = /** @class */ (function () {
    function UserService(http, route) {
        this.http = http;
        this.route = route;
        this.user = { id: 0, username: '', password: '', role: 1 };
        this.usernameLogin = '';
        this.passwordLogin = '';
        this.urlAPI = 'https://localhost:44327/api/user';
    }
    return UserService;
}());
exports.UserService = UserService;
//# sourceMappingURL=UserService.js.map