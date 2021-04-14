console.log("I am learning typescript");
var found = true;
var grade = 10;
var firstname = "Sumit Gupta";
console.log(found + "\n" + grade + "\n" + firstname);
function PrintMessage(id, name) {
    console.log("ID is ", id);
    console.log("Name is ", name);
}
PrintMessage(101, "Sumit Gupta");
PrintMessage(102, "Yogesh Patel");
// Simple Array
var arr;
arr = [1, 2, 3, 4, 5];
arr.forEach(function (element) {
    console.log(element);
});
// Object Array
var objArray = new Array(5);
for (var i = 1; i < objArray.length; i++) {
    objArray[i] = i * 2;
    console.log("Multiply by 2 is", objArray[i]);
}
// Array Destructuring
var arr1 = [12, 13];
var x = arr1[0], y = arr1[1];
console.log(x);
console.log(y);
