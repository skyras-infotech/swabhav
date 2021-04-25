import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
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

  constructor(private _contactService: UserService, private _router: Router, private _aRoute: ActivatedRoute, private _toastr: ToastrService) {
  }

  ngOnInit(): void {
    this._contactService.getAllUsersOfTenant(this._aRoute.snapshot.params.tenantID).subscribe(data => this.users = data);
  }

  addUser() {
    this._router.navigateByUrl(localStorage.getItem("tenantID") + "/add-user");
  }

  contactList(user: User) {
    this._router.navigateByUrl("contact-list/" + user.id);
  }

  deleteUser(user: User) {
    this._contactService.deleteUser(user).subscribe(res => {
      console.log(res);
      this._toastr.success("User Deleted..");
      this._router.routeReuseStrategy.shouldReuseRoute = () => false;
      this._router.onSameUrlNavigation = 'reload';
      this._router.navigateByUrl("users-list/" + localStorage.getItem("tenantID"));
    }, err => console.log(err));
  }

}
