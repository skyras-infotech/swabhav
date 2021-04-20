import { Injectable } from "@angular/core";
import { ICountry } from "./ICountry";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable()
export class CountryService
{
    constructor(private _http:HttpClient){}
    getCountries(): Observable<ICountry[]>
    {
        return this._http.get<ICountry[]>("https://restcountries.eu/rest/v2/all");
    }
}
