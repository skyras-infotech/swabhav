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
  constructor(private _userService: UserService, private _route: Router, private _aRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.tenantID = this._aRoute.snapshot.params.tenantID;
    this._userService.getNoOfContacts(localStorage.getItem("tenantID")).subscribe(res => this.noOfContacts = Number.parseInt(JSON.stringify(res)));
    this._userService.getNoOfUsers(this.tenantID).subscribe(res => this.noOfUsers = Number.parseInt(JSON.stringify(res)));
  }

  userList() {
    this._route.navigateByUrl("users-list/" + localStorage.getItem("tenantID"));
  }

}
