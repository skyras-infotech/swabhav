export class Customer {
    custCode: number;
    custName: string;
    constructor(name: string, code: number) {
        this.custName = name;
        this.custCode = code;
    }
    displayCustomer() {
        console.log ("Customer Code: " + 
        this.custCode + ", Customer Name: " + 
        this.custName );
    }
}