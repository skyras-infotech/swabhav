import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Address } from 'src/app/Model/address.model';
import { AddressService } from 'src/app/Services/address.service';

@Component({
  selector: 'app-add-address',
  templateUrl: './add-address.component.html',
  styles: ['./add-address.component.css']
})
export class AddAddressComponent implements OnInit {

  contactID: string;
  address: Address = new Address();
  constructor(private _addressService: AddressService, private _router: Router, private _activeRoute: ActivatedRoute,private _toastr:ToastrService) { }

  ngOnInit(): void {
    this.contactID = this._activeRoute.snapshot.params.contactID;
  }

  onSubmit(form: NgForm) {
    if (form.valid) {
      this._addressService.addAddress(this.address, this.contactID).subscribe(res => {
        console.log(res);
        this._toastr.success("Address Added..");
        this._router.navigateByUrl("address-list/" + this.contactID);
      }, err => console.log(err));
    }
  }

  backToList() {
    this._router.navigateByUrl("address-list/" + this.contactID);
  }

}
