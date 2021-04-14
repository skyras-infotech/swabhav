class Person
{
    private id:number;
    private name:string;

    public get GetID() : number {
        return this.id;
    }

    public get GetName() : string {
        return this.name;
    }
    
    public set SetID(v : number) {
        this.id = v;
    }
    public set SetName(v : string) {
        this.name = v;
    }
}

let p1:Person = new Person();
p1.SetID = 101;
p1.SetName = "Sumit Gupta";
console.log("Id is ",p1.GetID)
console.log("Name is ",p1.GetName)