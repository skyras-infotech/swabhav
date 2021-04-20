import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from "@angular/common/http";
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
import { PipeComponent } from './PipeDemo/pipe/pipe.component';
import { SnackCasePipe } from './SnackPipe/snackcase.pipe';
import { ParentComponent } from './Parent/parent.component';
import { ChildComponent } from './Child/child.component';
import { ContactComponent } from './contact/contact.component';
import { ContactService } from './Contact/contact.service';
import { CountryComponent } from './Country/country.component';

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
    LoginTemplateComponent,
    PipeComponent,
    SnackCasePipe,
    ParentComponent,
    ChildComponent,
    ContactComponent,
    CountryComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
  ],
  providers: [ContactService],
  bootstrap: [AppComponent]
})
export class AppModule { }
