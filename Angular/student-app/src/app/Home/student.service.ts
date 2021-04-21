import { Injectable } from '@angular/core';
import { IStudent } from "./IStudent";
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private _http:HttpClient) { }
   getContacts(): Observable<IStudent[]>
    {
        return this._http.get<IStudent[]>("http://gsmktg.azurewebsites.net/api/v1/techlabs/test/students/");
    }

}
