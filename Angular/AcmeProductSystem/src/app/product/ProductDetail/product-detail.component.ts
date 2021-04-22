import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from '../product-service.service';
import { Product } from '../product.model';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {

  product: Product = new Product();
  productID: number;
  constructor(private _activateRoute: ActivatedRoute, private _productService: ProductService,private _route:Router) { }

  ngOnInit(): void {
    this.productID = this._activateRoute.snapshot.params.id;
    this._productService.getAllProducts().subscribe(data => this.product = data.find(x => x.productId == this.productID));
  }

  back(){
    this._route.navigateByUrl("product-list");
  }
}
