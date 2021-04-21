import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerComponent } from './Customer/customer.component';
import { ShopkeeperComponent } from './Customer/shopkeeper.component';


@NgModule({
  declarations: [
    CustomerComponent,
    ShopkeeperComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    CustomerComponent,
    ShopkeeperComponent,
  ]
})
export class CustomDashboardModule { }
