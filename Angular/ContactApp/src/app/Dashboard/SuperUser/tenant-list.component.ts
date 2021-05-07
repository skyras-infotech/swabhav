import { Component, OnInit } from '@angular/core';
import { Tenant } from 'src/app/Model/tenant.model';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-tenant-list',
  templateUrl: './tenant-list.component.html',
  styleUrls: ['./tenant-list.component.css']
})
export class TenantListComponent implements OnInit {

  tenants: Tenant[];
  searchText: string;
  constructor(private _userService: UserService) { }

  ngOnInit(): void {
    this._userService.getAllTenant().subscribe(res => {
      
      this.tenants = res;
    });
  }

  deleteUser() { }

}
