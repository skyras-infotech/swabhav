import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { User } from 'src/app/Model/user.model';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-reg-tenant',
  templateUrl: './reg-tenant.component.html',
  styleUrls: ['./reg-tenant.component.css']
})
export class TenantRegistrationComponent implements OnInit {

  user: User = new User();
  tenant: any;
  constructor(private _userService: UserService, private _route: Router, private _toastr: ToastrService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    if (form.valid) {
      console.log(this.user);
      this._userService.addTenant(this.user).subscribe(res => {
        this.tenant = JSON.parse(res);
        this._userService.registerUser(this.user, this.tenant.id).subscribe(res => {
          console.log(res);
          this._toastr.success("New Tenant Register Sucessfully");
          this._route.navigateByUrl("/home");
        }, err => console.log(err));
      }, err => console.log(err));
    }
  }


}
