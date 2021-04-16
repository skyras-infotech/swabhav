import { Component } from '@angular/core';

@Component({
  selector: 'pricediscount-app',
  templateUrl: './pricediscount.component.html',
})
export class PriceDiscountComponent {
  cost: number = 0;
  price:number = 0;
  discount:number = 0;

  calculateCost() {
    this.cost = this.price - ((this.discount/100) * this.price);
  }
  title = 'Discount App';
}
