console.log("I am learning typescript");
let found:boolean = true;
let grade:number = 10;
let firstname:string = "Sumit Gupta";
console.log(found+"\n"+grade+"\n"+firstname);

function PrintMessage(id:number,name:string) {
    console.log("ID is ",id);
    console.log("Name is ",name);
}

PrintMessage(101,"Sumit Gupta");
PrintMessage(102,"Yogesh Patel");

// Simple Array
let arr:number[]
arr = [1,2,3,4,5];

arr.forEach(element => {
    console.log(element)
});

// Object Array
let objArray:number[] = new Array(5)

for (let i = 1; i < objArray.length; i++) {
    objArray[i] = i * 2;
    console.log("Multiply by 2 is",objArray[i])
}

// Array Destructuring
var arr1:number[] = [12,13] 
var[x,y] = arr1
console.log(x) 
console.log(y)