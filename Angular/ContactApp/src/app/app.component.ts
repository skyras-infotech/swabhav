import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
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
  favouriteContactRoute: string;
  superUser$: Observable<string>;
  superUserName: string;

  constructor(public loadService: LoaderService, private _userService: UserService, private _router: Router) {

  }
  ngOnInit(): void {
    this.isLoggedIn$ = this._userService.isLoggedIn;
    this.superUser$ = this._userService.getSuperUser;
    this.superUser$.subscribe(x => {
      this.superUserName = x;
    });
    this.currUser$ = this._userService.getCurrentUser;
    this.currUser$.subscribe(x => {
      this.currentUser = x;
      if (this.currentUser != null) {
        this.adminHomeRoute = "/" + this.currentUser.tenantId + "/admin-home";
        this.normalUserRoute = "/contact-list/" + this.currentUser.userId;
        this.favouriteContactRoute = "/favourite-contact-list/" + this.currentUser.userId;
      }
    }, err => console.log(err));
  }

  logout() {
    this._userService.setIsLoggedIn = false;
    this._userService.setCurrentUser = null;
    sessionStorage.clear();
    this._router.navigateByUrl("");
    setTimeout(function () {
      location.reload();
    }, 1000)
  }
}
