import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { BehaviorSubject, Observable } from 'rxjs';
import { User } from '../Model/user.model';
import { CurrentUser } from '../Model/current-user.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  tenID: string;
  constructor(private _http: HttpClient) {
    if (!!localStorage.getItem('userID')) {
      this.setIsLoggedIn = true;
      this.setCurrentUser = JSON.parse(localStorage.getItem("currentUser"));
    }
  }

  baseURL: string = "https://localhost:44301/api/v1/tenant/";

  private loggedIn: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);
  private currentUser: BehaviorSubject<CurrentUser> = new BehaviorSubject<CurrentUser>(null);

  public get isLoggedIn() {
    return this.loggedIn.asObservable();
  }

  public set setIsLoggedIn(v: boolean) {
    this.loggedIn.next(v);
  }

  public get getCurrentUser() {
    return this.currentUser.asObservable();
  }

  public set setCurrentUser(v: CurrentUser) {
    this.currentUser.next(v);
  }

  setTenantID(id: string) {
    this.tenID = id;
  }

  getAllUsersOfTenant(tenantID: string): Observable<User[]> {
    return this._http.get<User[]>(this.baseURL + tenantID + "/user");
  }

  addTenant(user: User) {
    return this._http.post(this.baseURL,
      {
        "tenantName": user.companyName,
        "companyStrength": user.companyStrength
      }, { responseType: 'text' });
  }

  login(email: string, pwd: string) {
    return this._http.post<User>(this.baseURL + this.tenID + "/User/loginIsUnique",
      {
        "email": email,
        "password": pwd
      });
  }

  deleteUser(user: User) {
    return this._http.delete(this.baseURL + user.tenantID + "/user/" + user.id, { responseType: 'text' });
  }

  registerUser(user: User, tenantID: string) {
    return this._http.post(this.baseURL + tenantID + "/user",
      {
        "username": user.username,
        "password": user.password,
        "email": user.email,
        "role": user.role != null ? user.role : "Admin"
      }, { responseType: 'text' });
  }

  getTenant(tenantName: string) {
    return this._http.get(this.baseURL + "tenantName/" + tenantName);
  }

  getNoOfUsers(tenantID: string) {
    return this._http.get(this.baseURL + tenantID + "/User/NoOfUsers");
  }

  getNoOfContacts(tenantID: string) {
    return this._http.get(this.baseURL + tenantID + "/User/NoOfUsersContacts");
  }

  checkTenantExist(tenantName: string) {
    return this._http.get(this.baseURL + "CheckTenantExistance/" + tenantName);
  }

  deleteTenant(tenantID: string) {
    return this._http.delete(this.baseURL + tenantID,{ responseType: 'text' });
  }
}
