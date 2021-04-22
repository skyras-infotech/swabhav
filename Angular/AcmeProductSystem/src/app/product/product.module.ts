import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductListComponent } from './ProductList/product-list.component';
import { ProductDetailComponent } from './ProductDetail/product-detail.component';
import { SharedModule } from './shared/shared.module';
import { HttpClientModule } from "@angular/common/http";
import { FormsModule } from "@angular/forms";
import { SearchFilter } from './search-filter.pipe';


@NgModule({
  declarations: [
    ProductListComponent,
    ProductDetailComponent,
    SearchFilter
  ],
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    HttpClientModule
  ]
})
export class ProductModule { }
