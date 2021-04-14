"use strict";
exports.__esModule = true;
exports.Customer = void 0;
var Customer = /** @class */ (function () {
    function Customer(name, code) {
        this.custName = name;
        this.custCode = code;
    }
    Customer.prototype.displayCustomer = function () {
        console.log("Customer Code: " +
            this.custCode + ", Customer Name: " +
            this.custName);
    };
    return Customer;
}());
exports.Customer = Customer;
