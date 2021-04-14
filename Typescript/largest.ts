let largestArry:number[] = new Array(10,15,20,30,45,20)

for (let i = 0; i < largestArry.length; i++) {
    for (let j = i+1; j < largestArry.length; j++) {
        if(largestArry[i] < largestArry[j])
        {
            let a = largestArry[i]
            largestArry[i] = largestArry[j]
            largestArry[j] = a
        }
    }
}

console.log("Max 3 Number in array are")
for (let i = 0; i < 3; i++) {
    console.log(largestArry[i])
}