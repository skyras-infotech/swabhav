import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Contact } from 'src/app/Model/contact.model';
import { ContactService } from 'src/app/Services/contact.service';

@Component({
  selector: 'app-add-contact',
  templateUrl: './add-contact.component.html',
  styleUrls: ['./add-contact.component.css']
})
export class AddContactComponent implements OnInit {

  contact: Contact = new Contact();
  constructor(private _contactService: ContactService, private _router: Router, private _toastr: ToastrService) { }

  ngOnInit(): void {

  }

  onSubmit(form: NgForm) {
    if (form.valid) {
      this._contactService.addContact(this.contact).subscribe(res => {
        console.log(res);
        this._toastr.success("Contact Added..");
        this._router.navigateByUrl("contact-list/" + localStorage.getItem("userID"));
      }, err => console.log(err));
    }

  }

  backToList() {
    this._router.navigateByUrl("contact-list/" + localStorage.getItem("userID"));
  }

}
