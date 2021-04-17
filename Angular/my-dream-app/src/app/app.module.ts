import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentComponent } from './Student/student.component';
import { WelcomeComponent } from "./Welcome/welcome.component";
import { EmployeeComponent } from './Employee/employee.component';
import { EventComponent } from './Event/event.component';
import { DiscountComponent } from './Discount/discount.component';
import { PriceDiscountComponent } from './PriceDiscount/pricediscount.component';
import { ProductComponent } from './ProductInfo/product.component';
import { TwowayComponent } from './TwoWayCommunication/twoway/twoway.component';
import { LoginComponent } from './login(Model)/login/login.component';
import { LoginTemplateComponent } from './login(Template)/login/loginTemplate.component';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    StudentComponent,
    EmployeeComponent,
    EventComponent,
    DiscountComponent,
    PriceDiscountComponent,
    ProductComponent,
    TwowayComponent,
    LoginComponent,
    LoginTemplateComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
