import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Contact } from 'src/app/Model/contact.model';
import { ContactService } from 'src/app/Services/contact.service';

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.component.html',
})
export class ContactListComponent implements OnInit {

  userID: string;
  contacts: Contact[];

  constructor(private _contactService: ContactService, private _router: Router) {
  }

  ngOnInit(): void {
    this._contactService.getContacts().subscribe(data => this.contacts = data);
  }

  addContact() {
    this._router.navigateByUrl(localStorage.getItem("userID") + "/add-contact");
  }

  updateContact(contact: Contact) {
    this._router.navigateByUrl("/edit-contact/" + contact.id, { state: contact })
  }

  addressList(contact: Contact) {
    this._router.navigateByUrl("address-list/" + contact.id);
  }

  deleteContact(contact: Contact) {
    this._contactService.deleteContact(contact).subscribe(res => {
      console.log(res);
      this._router.routeReuseStrategy.shouldReuseRoute = () => false;
      this._router.onSameUrlNavigation = 'reload';
      this._router.navigateByUrl("contact-list/"+localStorage.getItem("userID"));
    }, err => console.log(err));
  }

}
