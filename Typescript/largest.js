var largestArry = new Array(10, 15, 20, 30, 45, 20);
for (var i = 0; i < largestArry.length; i++) {
    for (var j = i + 1; j < largestArry.length; j++) {
        if (largestArry[i] < largestArry[j]) {
            var a = largestArry[i];
            largestArry[i] = largestArry[j];
            largestArry[j] = a;
        }
    }
}
console.log("Max 3 Number in array are");
for (var i = 0; i < 3; i++) {
    console.log(largestArry[i]);
}
