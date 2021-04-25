import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { User } from 'src/app/Model/user.model';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent implements OnInit {

  user: User = new User();
  roleList = [
    { role: "Normal User" },
    { role: "Admin" },
  ];
  constructor(private _userService: UserService, private _router: Router, private _toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    if (form.valid) {
      console.log(this.user);
      this._userService.registerUser(this.user, localStorage.getItem("tenantID")).subscribe(res => {
        console.log(res);
        this._toastr.success("User Added..");
        this._router.navigateByUrl("users-list/" + localStorage.getItem("tenantID"));
      }, err => console.log(err));
    }
  }

  backToList() {
    this._router.navigateByUrl("users-list/" + localStorage.getItem("tenantID"));
  }

}
