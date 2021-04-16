import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentComponent } from './Student/student.component';
import { WelcomeComponent } from "./Welcome/welcome.component";
import { EmployeeComponent } from './Employee/employee.component';
import { EventComponent } from './Event/event.component';
import { DiscountComponent } from './Discount/discount.component';
import { PriceDiscountComponent } from './PriceDiscount/pricediscount.component';
import { ProductComponent } from './ProductInfo/product.component';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    StudentComponent,
    EmployeeComponent,
    EventComponent,
    DiscountComponent,
    PriceDiscountComponent,
    ProductComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
