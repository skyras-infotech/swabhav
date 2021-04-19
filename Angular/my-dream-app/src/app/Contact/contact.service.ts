import { Injectable } from "@angular/core";
import { IContact } from "./IContact";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class ContactService
{
    constructor(private _http:HttpClient){}
    // getContacts(): Observable<IContact[]>
    // {
    //     return this._http.get<IContact[]>("https://localhost:44301/api/Contact");
    // }

    //with promise
    getContacts(): Promise<IContact[]>
    {
        return this._http.get<IContact[]>("https://localhost:44301/api/Contact").toPromise();
    }
}
