import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SuperUserLoginComponent } from './SuperUserLogin/super-user-login.component';
import { LoginComponent } from './Tenant/Login/login.component';
import { TenantRegistrationComponent } from './Tenant/Register/reg-tenant.component';

const routes: Routes = [
  { path: "", redirectTo: "/home", pathMatch: "full" },
  { path: "home", component: LoginComponent },
  { path: "register", component: TenantRegistrationComponent },
  { path: "super-user-login", component: SuperUserLoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
