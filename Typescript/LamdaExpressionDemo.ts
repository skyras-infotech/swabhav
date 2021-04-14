let sum = (x: number,y: number) : number => {
    return x + y;
}

console.log("The Sum is ",sum(10,20));

class Employee {
    empCode: number;
    empName: string;

    constructor(code: number, name: string) {
        this.empName = name;
        this.empCode = code;
    }

    display = () => console.log(this.empCode +' ' + this.empName)
}
let emp = new Employee(10, "Sumit");
emp.display();