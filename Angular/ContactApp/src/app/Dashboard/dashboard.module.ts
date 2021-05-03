import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddContactComponent } from './Contact/AddContact/add-contact.component';
import { UpdateContactComponent } from './Contact/UpdateContact/update-contact.component';
import { ContactListComponent } from './Contact/ContactList/contact-list.component';
import { AddAddressComponent } from './Address/AddAddress/add-address.component';
import { UpdateAddressComponent } from './Address/UpdateAddress/update-address.component';
import { AddressListComponent } from './Address/AddressList/address-list.component';
import { UpdateUserComponent } from './User/UpdateUser/update-user.component';
import { UserListComponent } from './User/UserList/user-list.component';
import { FormsModule } from '@angular/forms';
import { DashboardRoutingModule } from './dashboard-routing.module';
import { AddUserComponent } from './User/AddUser/add-user.component';
import { CheckPasswordEqualityDirective } from '../Tenant/check-password.directive';
import { AdminDashboardComponent } from './User/AdminDashboard/admin-dashboard.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { SearchContactFilter } from './search-contact.pipe';
import { SearchUserFilter } from './search-user.pipe';
import { SearchAddressFilter } from './search-address.pipe';
import { TenantListComponent } from './SuperUser/tenant-list.component';
import { SearchTenantFilter } from './search-tenant.pipe';
import { FavouriteContactListComponent } from './Contact/FavouriteContactList/favourite-contact-list.component';

@NgModule({
  declarations: [
    AddContactComponent,
    UpdateContactComponent,
    ContactListComponent,
    AddAddressComponent,
    UpdateAddressComponent,
    AddressListComponent,
    UpdateUserComponent,
    UserListComponent,
    AddUserComponent,
    CheckPasswordEqualityDirective,
    AdminDashboardComponent,
    SearchContactFilter,
    SearchUserFilter,
    SearchAddressFilter,
    TenantListComponent,
    SearchTenantFilter,
    FavouriteContactListComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    DashboardRoutingModule,
    FontAwesomeModule
  ]
})
export class DashboardModule { }
