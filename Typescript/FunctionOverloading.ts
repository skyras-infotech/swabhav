function add(a:any, b:any):any;

function add(a:number, b:number): number;

function add(a: any, b:any): any {
    return a + b;
}
console.log(add(10,20));
console.log(add("Sumit ","Gupta"));
console.log(add(10.0,20.20));