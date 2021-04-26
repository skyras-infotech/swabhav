import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Contact } from '../Model/contact.model';

@Injectable({
  providedIn: 'root'
})
export class ContactService {

  tenantID: string = localStorage.getItem("tenantID");
  userID: string = localStorage.getItem("userID");
  baseURL: string = "https://localhost:44301/api/v1/tenant/" + this.tenantID + "/user/" + this.userID + "/Contact";

  constructor(private _http: HttpClient) {
    console.log("Tenant ID " + this.tenantID);
    console.log("User ID " + this.userID);
  }

  // getContacts(userID:string): Observable<Contact[]> {
  //   return this._http.get<Contact[]>("https://localhost:44301/api/v1/tenant/" + this.tenantID + "/user/" + userID + "/Contact");
  // }

  getContacts(): Observable<Contact[]> {
    return this._http.get<Contact[]>(this.baseURL);
  }

  addContact(contact: Contact) {
    return this._http.post(this.baseURL, contact, { responseType: 'text' });
  }

  updateContact(contact: Contact) {
    return this._http.put(this.baseURL + "/" + contact.id, contact, { responseType: 'text' });
  }

  deleteContact(contact: Contact) {
    return this._http.delete(this.baseURL + "/" + contact.id, { responseType: 'text' });
  }
}
