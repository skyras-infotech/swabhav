interface IPerson
{
    firstName:string,
    lastName:string,
    walk:() => string
}

var User : IPerson =
{
    firstName:"Sumit",
    lastName:"Gupta",
    walk:():string => {return "Person is walking"},
}

console.log("Username is ",User.firstName+" "+User.lastName)
console.log(User.walk())