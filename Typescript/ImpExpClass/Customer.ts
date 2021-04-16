export class Customer
{
    private _firstName:string;
    private _lastName:string;

    constructor(fname:string,lname:string) {
        this._firstName = fname;
        this._lastName = lname;
    }
    
    public get getFirstName() : string {
        return this._firstName;
    }

    public get getLastName() : string {
        return this._lastName;
    }
    
}