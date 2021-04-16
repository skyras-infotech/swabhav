"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Customer = void 0;
var Customer = /** @class */ (function () {
    function Customer(fname, lname) {
        this._firstName = fname;
        this._lastName = lname;
    }
    Object.defineProperty(Customer.prototype, "getFirstName", {
        get: function () {
            return this._firstName;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Customer.prototype, "getLastName", {
        get: function () {
            return this._lastName;
        },
        enumerable: false,
        configurable: true
    });
    return Customer;
}());
exports.Customer = Customer;
