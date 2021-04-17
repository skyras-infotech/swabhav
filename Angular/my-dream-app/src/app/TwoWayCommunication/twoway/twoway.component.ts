import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-twoway',
  templateUrl: './twoway.component.html',
})
export class TwowayComponent implements OnInit {

  firstname:string = "";
  lastname : string= "";
  constructor() { }

  nameChanged(event:any)
  {
    console.log(event);
    this.firstname = event;
  }
  ngOnInit(): void {
  }

}
