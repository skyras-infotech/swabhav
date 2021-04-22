import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductDetailComponent } from './product/ProductDetail/product-detail.component';
import { ProductListComponent } from './product/ProductList/product-list.component';
import { WelcomeComponent } from './welcome/welcome.component';

const routes: Routes = [
  { path: "home", component: WelcomeComponent },
  { path: "product-list", component: ProductListComponent },
  { path: "product-detail/:id", component: ProductDetailComponent },
  { path: "", redirectTo: "/home", pathMatch: "full" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
