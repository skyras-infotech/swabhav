import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Contact } from '../Model/contact.model';

@Injectable({
  providedIn: 'root'
})
export class ContactService {

  tenantID: string = JSON.parse(sessionStorage.getItem("currentUser"))?.tenantID;
  userID: string = JSON.parse(sessionStorage.getItem("currentUser"))?.userID;
  baseURL: string = "https://localhost:44301/api/v1/tenant/" + this.tenantID + "/user/" + this.userID + "/Contact";
  token: string = sessionStorage.getItem("user-info");

  constructor(private _http: HttpClient) {
  }

  getContacts(): Observable<Contact[]> {
    return this._http.get<Contact[]>(this.baseURL);
  }

  getFavouriteContacts(): Observable<Contact[]> {
    return this._http.get<Contact[]>(this.baseURL + "/favorite-list");
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
