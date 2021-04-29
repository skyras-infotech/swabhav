import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Contact } from 'src/app/Model/contact.model';
import { ContactService } from 'src/app/Services/contact.service';

@Component({
  selector: 'app-update-contact',
  templateUrl: './update-contact.component.html',
  styleUrls: ['./update-contact.component.css']
})
export class UpdateContactComponent implements OnInit {

  contact: Contact;
  constructor(private _contactService: ContactService, private _router: Router, private _toastr: ToastrService) { }

  ngOnInit(): void {
    this.contact = history.state
  }

  onSubmit(form: NgForm) {
    if (form.valid) {
      this._contactService.updateContact(this.contact).subscribe(res => {
        console.log(res)
        this._toastr.success("Contact Updated..");
        this._router.navigateByUrl("contact-list/" + JSON.parse(sessionStorage.getItem("currentUser")).userID);
      }, err => console.log(err));
    }
  }

  backToList() {
    this._router.navigateByUrl("contact-list/" + JSON.parse(sessionStorage.getItem("currentUser")).userID);
  }

}
