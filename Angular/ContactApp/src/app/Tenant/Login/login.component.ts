import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { CurrentUser } from 'src/app/Model/current-user.model';
import { User } from 'src/app/Model/user.model';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  user: User = new User();
  tenantDetails: any;
  btnDisable: boolean = true;
  exists: boolean = false;
  currentUser: CurrentUser = new CurrentUser();
  constructor(private _userService: UserService, private _route: Router, private _toastr: ToastrService) { 
    
  }

  ngOnInit(): void {
    if (localStorage.getItem("userID") != null || localStorage.getItem("userID") != null) {
      this._route.navigateByUrl("contact-list/" + localStorage.getItem("userID"));
    } else {
      this._route.navigateByUrl("");
    }
    
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
    console.log(this.user);
    this._userService.login(this.user.email, this.user.password).subscribe(res => {
      console.log(res);
      if (res != null) {
        localStorage.setItem("userID", res.id);
        localStorage.setItem("tenantID", res.tenantID);
        this._toastr.success("Login Sucess");
        this._userService.setIsLoggedIn = true;
        this.currentUser.email = res.email;
        this.currentUser.role = res.role;
        this.currentUser.username = res.username;
        this.currentUser.companyName = this.tenantDetails.tenantName.toString();
        this.currentUser.companyStrength = this.tenantDetails.companyStrength.toString();
        console.log(this.currentUser);
        localStorage.setItem("currentUser", JSON.stringify(this.currentUser));
        this._userService.setCurrentUser = this.currentUser;
        if (res.role == "Admin") {
          this._route.navigateByUrl(res.tenantID + "/admin-home");

        } else {
          this._route.navigateByUrl("contact-list/" + res.id);
        }
      }
    }, (err: any) => this._toastr.error(err.error));
  }
}
