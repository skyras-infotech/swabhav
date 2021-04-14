var Person = /** @class */ (function () {
    function Person() {
    }
    Object.defineProperty(Person.prototype, "GetID", {
        get: function () {
            return this.id;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Person.prototype, "GetName", {
        get: function () {
            return this.name;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Person.prototype, "SetID", {
        set: function (v) {
            this.id = v;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Person.prototype, "SetName", {
        set: function (v) {
            this.name = v;
        },
        enumerable: false,
        configurable: true
    });
    return Person;
}());
var p1 = new Person();
p1.SetID = 101;
p1.SetName = "Sumit Gupta";
console.log("Id is ", p1.GetID);
console.log("Name is ", p1.GetName);
