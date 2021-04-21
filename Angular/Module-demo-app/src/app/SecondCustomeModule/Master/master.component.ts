import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-master',
  templateUrl: './master.component.html',
  styles: [
  ]
})
export class MasterComponent implements OnInit {

  ratingStarValue: number;
  constructor() { }

  ngOnInit(): void {
  }

}
