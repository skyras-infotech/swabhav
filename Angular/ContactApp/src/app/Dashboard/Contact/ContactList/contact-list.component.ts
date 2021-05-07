import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Contact } from 'src/app/Model/contact.model';
import { ContactService } from 'src/app/Services/contact.service';

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.component.html',
})
export class ContactListComponent implements OnInit {

  userID: string;
  contacts: Contact[];
  searchText: string;
  favorite: string = "assets/unstar.png";

  constructor(private _contactService: ContactService, private _router: Router,private _toastr:ToastrService) {

  }

  ngOnInit(): void {
    this._contactService.getContacts().subscribe(data => this.contacts = data);
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
      console.log(res);
      this._toastr.success("Contact Deleted..");
      this._router.routeReuseStrategy.shouldReuseRoute = () => false;
      this._router.onSameUrlNavigation = 'reload';
      this._router.navigateByUrl("/contact-list/" + JSON.parse(sessionStorage.getItem("currentUser")).userId);
    }, err => console.log(err));
  }

}
