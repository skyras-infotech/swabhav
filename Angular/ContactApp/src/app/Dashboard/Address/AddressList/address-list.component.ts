import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Address } from 'src/app/Model/address.model';
import { AddressService } from 'src/app/Services/address.service';

@Component({
  selector: 'app-address-list',
  templateUrl: './address-list.component.html',
  styles: [
  ]
})
export class AddressListComponent implements OnInit {

  addresses: Address[];
  contactID: string;
  searchText: string;
  constructor(private _addressService: AddressService, private _router: Router, private _activatedRoute: ActivatedRoute,private _toastr:ToastrService) {
  }

  ngOnInit(): void {
    this.contactID = this._activatedRoute.snapshot.params.contactID;
    this._addressService.getAddresses(this.contactID).subscribe(data => this.addresses = data);
  }

  addAddress() {
    this._router.navigateByUrl("/" + this.contactID + "/add-address");
  }

  updateAddress(address: Address) {
    this._router.navigateByUrl("/" + this.contactID + "/edit-address/" + address.id, { state: address })
  }

  deleteAddress(address: Address) {
    this._addressService.deleteAddress(address, this.contactID).subscribe(res => {
      
      this._toastr.success("Address Deleted..");
      this._router.routeReuseStrategy.shouldReuseRoute = () => false;
      this._router.onSameUrlNavigation = 'reload';
      this._router.navigateByUrl("/address-list/" + this.contactID);
    }, err => this._toastr.error(err.error));
  }

  backToList() {
    this._router.navigateByUrl("/contact-list/" + JSON.parse(sessionStorage.getItem("currentUser")).userId);
  }

}
