import { Component, OnInit } from '@angular/core';
import { ContactService } from './contact.service';
import { IContact } from './IContact';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.scss'],
  providers: [ContactService]
})
export class ContactComponent implements OnInit {

  contacts: IContact[];
  
  private _contactService: ContactService;
  constructor(contactService: ContactService) {
    this._contactService = contactService;
  }

  // ==========  OR ========

  //constructor(private _contactService:ContactService) { }

  ngOnInit(): void {
    this._contactService.getContacts().then(data => this.contacts = data).catch(err => console.log(err));
  }

}
