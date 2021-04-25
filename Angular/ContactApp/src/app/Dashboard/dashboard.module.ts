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
    
  ],
  imports: [
    CommonModule,
    FormsModule,
    DashboardRoutingModule,
    FontAwesomeModule
  ]
})
export class DashboardModule { }
