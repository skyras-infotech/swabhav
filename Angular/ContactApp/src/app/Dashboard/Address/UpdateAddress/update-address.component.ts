import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Address } from 'src/app/Model/address.model';
import { AddressService } from 'src/app/Services/address.service';

@Component({
  selector: 'app-update-address',
  templateUrl: './update-address.component.html',
  styles: ['./update-address.component.css']
})
export class UpdateAddressComponent implements OnInit {

  address: Address;
  contactID: string;
  constructor(private _addressService: AddressService, private _router: Router, private _activeRoute: ActivatedRoute, private _toastr: ToastrService) { }

  ngOnInit(): void {
    this.address = history.state;
    this._activeRoute.paramMap.subscribe(param => {
      this.contactID = param.get("contactID");
    });
  }

  onSubmit() {
    this._addressService.updateAddress(this.address, this.contactID).subscribe(res => {
      console.log(res);
      this._toastr.success("Address Updated..");
      this._router.navigateByUrl("address-list/" + this.contactID);
    }, err => console.log(err));
  }

  backToList() {
    this._router.navigateByUrl("address-list/" + this.contactID);
  }

}
