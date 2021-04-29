import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { SuperUser } from '../Model/super-user.model';
import { UserService } from '../Services/user.service';
import jwt_decode from "jwt-decode";

@Component({
  selector: 'app-super-user-login',
  templateUrl: './super-user-login.component.html',
  styleUrls: ['./super-user-login.component.css']
})
export class SuperUserLoginComponent implements OnInit {

  superUser: SuperUser = new SuperUser();
  home: string = "";
  constructor(private _userService: UserService, private _route: Router, private _toastr: ToastrService) {

  }

  ngOnInit(): void {
  }

  onSubmit() {
    console.log(this.superUser);
    this._userService.superLogin(this.superUser.username, this.superUser.password).subscribe(res => {
      console.log(res);
      sessionStorage.setItem("super-user-info", res);
      var payload = jwt_decode(res);
      sessionStorage.setItem("superUser", JSON.parse(JSON.stringify(payload)).username);
      this._toastr.success("Login Sucess");
      this._userService.setIsLoggedIn = true;
      this._userService.setSuperUser = JSON.parse(JSON.stringify(payload)).username;
      this._route.navigateByUrl("/tenant-list");
    },
      err => {
        this._toastr.error(err.error);
      });
  }
}
