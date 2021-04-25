import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddAddressComponent } from './Address/AddAddress/add-address.component';
import { AddressListComponent } from './Address/AddressList/address-list.component';
import { UpdateAddressComponent } from './Address/UpdateAddress/update-address.component';
import { AddContactComponent } from './Contact/AddContact/add-contact.component';
import { ContactListComponent } from './Contact/ContactList/contact-list.component';
import { UpdateContactComponent } from './Contact/UpdateContact/update-contact.component';
import { AddUserComponent } from './User/AddUser/add-user.component';
import { AdminDashboardComponent } from './User/AdminDashboard/admin-dashboard.component';
import { UserListComponent } from './User/UserList/user-list.component';

const routes: Routes = [
  { path: "contact-list/:userID", component: ContactListComponent },
  { path: ":userID/add-contact", component: AddContactComponent },
  { path: "edit-contact/:contactID", component: UpdateContactComponent },
  { path: "address-list/:contactID", component: AddressListComponent },
  { path: ":contactID/add-address", component: AddAddressComponent },
  { path: ":contactID/edit-address/:addressID", component: UpdateAddressComponent },
  { path: "users-list/:tenantID", component: UserListComponent },
  { path: ":tenantID/add-user", component: AddUserComponent },
  { path: ":tenantID/admin-home", component: AdminDashboardComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule { }
