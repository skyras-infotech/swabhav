import { Component } from '@angular/core';
import { IProduct } from "./IProduct";

@Component({
  selector: 'product-app',
  templateUrl: './product.component.html',
})
export class ProductComponent {
  id: string = "";
  pname: string = "";
  rate: string = "";
  cost: string = "";
  discount: string = "";
  ProductList: IProduct[] = [];
  loadProduct() {
    this.ProductList.push({
      id: parseInt(this.id),
      pname: this.pname,
      rating: parseInt(this.rate),
      cost: parseInt(this.cost),
      discount: parseInt(this.discount),
      totalCost: parseInt(this.cost) - ((parseInt(this.discount) / 100) * parseInt(this.cost))
    });
    this.id = "";
    this.pname = "";
    this.rate = "";
    this.cost = "";
    this.discount = "";
  }
  title = 'Product List';
}
