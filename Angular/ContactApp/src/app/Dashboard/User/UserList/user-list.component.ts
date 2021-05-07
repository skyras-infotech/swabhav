import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { User } from 'src/app/Model/user.model';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styles: []
})
export class UserListComponent implements OnInit {

  users: User[];
  searchText:string;
  tenantID:string;
  constructor(private _contactService: UserService, private _router: Router, private _toastr: ToastrService) {
  }

  ngOnInit(): void {
    this.tenantID = JSON.parse(sessionStorage.getItem("currentUser"))?.tenantId;
    this._contactService.getAllUsersOfTenant(this.tenantID).subscribe(data => {
      this.users = data;
    });
  }

  addUser() {
    this._router.navigateByUrl(this.tenantID + "/add-user");
  }

  deleteUser(user: User) {
    console.log(user);
    this._contactService.deleteUser(user).subscribe(res => {
      console.log(res);
      this._toastr.success("User Deleted..");
      this._router.routeReuseStrategy.shouldReuseRoute = () => false;
      this._router.onSameUrlNavigation = 'reload';
      this._router.navigateByUrl("/users-list/" + this.tenantID);
    }, err => console.log(err));
  }

}
