import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { ToastrModule } from "ngx-toastr";
import { MatProgressSpinnerModule } from "@angular/material/progress-spinner";
import { InterceptorService } from './Loader/interceptor.service';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { DashboardModule } from './Dashboard/dashboard.module';
import { LoginComponent } from './Tenant/Login/login.component';
import { TenantRegistrationComponent } from './Tenant/Register/reg-tenant.component';
import { CheckPasswordEquality } from './Tenant/check-passsword.directive';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    TenantRegistrationComponent,
    CheckPasswordEquality
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatProgressSpinnerModule,
    ToastrModule.forRoot({
      timeOut: 2000,
    }),
    DashboardModule,
  ],
  providers: [HttpClientModule, {
    provide: HTTP_INTERCEPTORS,
    useClass: InterceptorService,
    multi: true,
  },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
