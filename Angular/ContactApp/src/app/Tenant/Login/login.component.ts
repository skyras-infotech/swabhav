import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { CurrentUser } from 'src/app/Model/current-user.model';
import { SuperUser } from 'src/app/Model/super-user.model';
import { User } from 'src/app/Model/user.model';
import { UserService } from 'src/app/Services/user.service';
import jwt_decode from "jwt-decode";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  user: User = new User();
  superUser: SuperUser = new SuperUser();
  tenantDetails: any;
  btnDisable: boolean = true;
  exists: boolean = false;
  currentUser: CurrentUser = new CurrentUser();
  constructor(private _userService: UserService, private _route: Router, private _toastr: ToastrService) {

  }

  ngOnInit(): void {
  }

  register() {
    this._route.navigateByUrl("/register");
  }

  onChangeEvent(event: any) {
    this._userService.getTenant(event.target.value).subscribe(res => {
      if (res != null) {
        this.tenantDetails = JSON.parse(JSON.stringify(res));
        this._userService.setTenantID(this.tenantDetails.id);
        console.log(this.tenantDetails);
        this.btnDisable = false;
        this.exists = true;
      }
    }, err => {
      this._toastr.error(err.error);
      this.exists = false;
      this.btnDisable = true;
    });
  }

  onSubmit() {
    this._userService.login(this.user.email, this.user.password).subscribe(res => {
      if (res != null) {
        sessionStorage.setItem("user-info", res);
        var payload = jwt_decode<User>(res);

        console.log(payload);
        this._toastr.success("Login Sucess");
        this._userService.setIsLoggedIn = true;
        this.currentUser.email = payload.email;
        this.currentUser.role = payload.role;
        this.currentUser.username = payload.username;
        this.currentUser.userId = payload.id;
        this.currentUser.tenantId = payload.tenantId;
        this.currentUser.companyName = this.tenantDetails.tenantName.toString();
        this.currentUser.companyStrength = this.tenantDetails.companyStrength.toString();
        sessionStorage.setItem("currentUser", JSON.stringify(this.currentUser));
        this._userService.setCurrentUser = this.currentUser;
        if (payload.role == "Admin") {
          this._route.navigateByUrl("/"+payload.tenantId + "/admin-home");

        } else {
          this._route.navigateByUrl("/contact-list/" + payload.id);
        }
      }
    }, (err: any) => {
      this._toastr.error(err.error);
      console.log(err);
    });
  }

  onSuperLogin() {
    this._route.navigateByUrl("/super-user-login");
  }
}
