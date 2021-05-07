import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { Address } from '../Model/address.model';


@Injectable({
  providedIn: 'root'
})
export class AddressService {

  tenantID: string = JSON.parse(sessionStorage.getItem("currentUser"))?.tenantId;
  userID: string = JSON.parse(sessionStorage.getItem("currentUser"))?.userId;
  baseURL: string = "https://sumit-contact-api.azurewebsites.net/api/v1/tenant/" + this.tenantID + "/user/" + this.userID + "/Contact";

  constructor(private _http: HttpClient) {

  }

  getAddresses(contactID: string): Observable<Address[]> {
    return this._http.get<Address[]>(this.baseURL + "/" + contactID + "/Address");
  }

  addAddress(address: Address, contactID: string) {
    return this._http.post(this.baseURL + "/" + contactID + "/Address", address, { responseType: 'text' });
  }

  updateAddress(address: Address, contactID: string) {
    return this._http.put(this.baseURL + "/" + contactID + "/Address" + "/" + address.id, address, { responseType: 'text' });
  }

  deleteAddress(address: Address, contactID: string) {
    return this._http.delete(this.baseURL + "/" + contactID + "/Address" + "/" + address.id, { responseType: 'text' });
  }
}
