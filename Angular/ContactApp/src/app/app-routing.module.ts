import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddAddressComponent } from './Dashboard/Address/AddAddress/add-address.component';
import { AddressListComponent } from './Dashboard/Address/AddressList/address-list.component';
import { UpdateAddressComponent } from './Dashboard/Address/UpdateAddress/update-address.component';
import { AddContactComponent } from './Dashboard/Contact/AddContact/add-contact.component';
import { ContactListComponent } from './Dashboard/Contact/ContactList/contact-list.component';
import { UpdateContactComponent } from './Dashboard/Contact/UpdateContact/update-contact.component';
import { LoginComponent } from './Tenant/Login/login.component';
import { TenantRegistrationComponent } from './Tenant/Register/reg-tenant.component';

const routes: Routes = [
  // { path: "contact-list/:userID", component: ContactListComponent },
  // { path: ":userID/add-contact", component: AddContactComponent },
  // { path: "edit-contact/:contactID", component: UpdateContactComponent },
  // { path: "address-list/:contactID", component: AddressListComponent },
  // { path: ":contactID/add-address", component: AddAddressComponent },
  // { path: ":contactID/edit-address/:addressID", component: UpdateAddressComponent },
  { path: "", redirectTo: "/home", pathMatch: "full" },
  { path: "home", component: LoginComponent },
  { path: "register", component: TenantRegistrationComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
