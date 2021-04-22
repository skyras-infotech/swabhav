import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ProductService } from '../product-service.service';
import { Product } from '../product.model';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styles: [
  ]
})
export class ProductListComponent implements OnInit {

  showImage: boolean = false;
  productList: Product[];
  searchText: string;
  constructor(private _router: Router, private _productService: ProductService) { }

  ngOnInit(): void {
    this._productService.getAllProducts().subscribe(data => this.productList = data);
  }

  isImageHide() {
    this.showImage = !this.showImage;
  }

  productDetails(product: Product) {
    this._router.navigateByUrl("/product-detail/" + product.productId);
  }

}
