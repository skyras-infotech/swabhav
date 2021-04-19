import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.scss']
})
export class ParentComponent implements OnInit {

  parentdata:string;
  childdata:string;
  constructor() { }

  ngOnInit(): void {
  }

  setChildData(event)
  {
    this.childdata = event;
  }
}
