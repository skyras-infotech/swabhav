import { Component } from '@angular/core';

@Component({
  selector: 'discount-app',
  templateUrl: './discount.component.html',
})
export class DiscountComponent {
  cost: number = 0;

  calculateCost(price:string,rate:string) {
    this.cost = parseInt(price) - (parseInt(rate)/100 * parseInt(price))
  }
  title = 'Discount App';
}
