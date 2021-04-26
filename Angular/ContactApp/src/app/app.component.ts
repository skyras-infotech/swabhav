import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { LoaderService } from './Loader/loader.service';
import { CurrentUser } from './Model/current-user.model';
import { UserService } from './Services/user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  title = 'Contact App';
  myDate = new Date();
  isLoggedIn$: Observable<boolean>;
  currUser$: Observable<CurrentUser>;
  currentUser: CurrentUser = new CurrentUser();
  adminHomeRoute: string;
  normalUserRoute: string;

  constructor(public loadService: LoaderService, private _userService: UserService, private _router: Router) {

  }
  ngOnInit(): void {
    this.isLoggedIn$ = this._userService.isLoggedIn;
    this.currUser$ = this._userService.getCurrentUser;
    this.currUser$.subscribe(x => {
      this.currentUser = x;
      this.adminHomeRoute = localStorage.getItem("tenantID") + "/admin-home";
      this.normalUserRoute = "contact-list/" + localStorage.getItem("userID");
    }, err => console.log(err));
  }

  logout() {
    this._userService.setIsLoggedIn = false;
    this._userService.setCurrentUser = null;
    localStorage.clear();
    this._router.navigateByUrl("");
    setTimeout(function () {
      location.reload();
    }, 1000)
  }
}
