import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { faAd, faBible, faPhone, faUsers } from '@fortawesome/free-solid-svg-icons';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-admin-dashboard',
  templateUrl: './admin-dashboard.component.html',
  styleUrls: ['./admin-dashboard.component.css']
})
export class AdminDashboardComponent implements OnInit {

  noOfUsers: number;
  noOfContacts: number;
  faUsers = faUsers;
  faPhone = faPhone;
  faBible = faBible;
  tenantID: string;
  constructor(private _userService: UserService, private _route: Router) { }

  ngOnInit(): void {
    this.tenantID = JSON.parse(sessionStorage.getItem("currentUser")).tenantId;
    this._userService.getNoOfContacts(this.tenantID).subscribe(res => this.noOfContacts = Number.parseInt(JSON.stringify(res)));
    this._userService.getNoOfUsers(this.tenantID).subscribe(res => this.noOfUsers = Number.parseInt(JSON.stringify(res)));
  }

  userList() {
    this._route.navigateByUrl("/users-list/" + this.tenantID);
  }

}
