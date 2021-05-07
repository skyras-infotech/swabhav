import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Contact } from 'src/app/Model/contact.model';
import { ContactService } from 'src/app/Services/contact.service';

@Component({
  selector: 'app-favourite-contact-list',
  templateUrl: './favourite-contact-list.component.html',
})
export class FavouriteContactListComponent implements OnInit {

  userID: string;
  contacts: Contact[];
  searchText: string;

  constructor(private _contactService: ContactService, private _router: Router,private _toastr:ToastrService) {
  }

  ngOnInit(): void {
    this._contactService.getFavouriteContacts().subscribe(data => this.contacts = data);
  }

  addContact() {
    this._router.navigateByUrl("/"+JSON.parse(sessionStorage.getItem("currentUser")).userId + "/add-contact");
  }

  updateContact(contact: Contact) {
    this._router.navigateByUrl("/edit-contact/" + contact.id, { state: contact })
  }

  addressList(contact: Contact) {
    this._router.navigateByUrl("/address-list/" + contact.id);
  }

  deleteContact(contact: Contact) {
    this._contactService.deleteContact(contact).subscribe(res => {
      
      this._router.routeReuseStrategy.shouldReuseRoute = () => false;
      this._router.onSameUrlNavigation = 'reload';
      this._router.navigateByUrl("/contact-list/" + JSON.parse(sessionStorage.getItem("currentUser")).userId);
    }, err => this._toastr.error(err.error));
  }

}
