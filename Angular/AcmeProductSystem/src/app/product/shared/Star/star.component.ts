import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-star',
  templateUrl: './star.component.html',
  styles: [
  ]
})
export class StarComponent implements OnInit {

  @Input("ratingValue") ratingValue:number;
  constructor() { }

  ngOnInit(): void {
  }

}
