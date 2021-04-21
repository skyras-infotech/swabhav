import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-rating',
  templateUrl: './rating.component.html',
  styles: [
  ]
})
export class RatingComponent implements OnInit {
  @Input("ratingValue") ratingValue:number;
  
  constructor() { 
  }
  
  ngOnInit(): void {
    console.log(this.ratingValue);
  }

}
