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

  isMobileExist = false;
  contact: Contact = new Contact();
  constructor(private _contactService: ContactService, private _router: Router, private _toastr: ToastrService) { }

  ngOnInit(): void {
    if (sessionStorage.getItem('user-info') == null) {
      this._router.navigateByUrl("");
    }
  }

  onSubmit(form: NgForm) {
    (this.contact);
    if (form.valid) {
      this._contactService.addContact(this.contact).subscribe(res => {
        
        this.isMobileExist = false;
        this._toastr.success("Contact Added..");
        this._router.navigateByUrl("/contact-list/" + JSON.parse(sessionStorage.getItem("currentUser")).userId);
      }, err => {
        this._toastr.error(err.error);
        this.isMobileExist = true;
        this._toastr.error(err.error);
      });
    }
  }

  backToList() {
    this._router.navigateByUrl("/contact-list/" + JSON.parse(sessionStorage.getItem("currentUser")).userId);
  }

}
