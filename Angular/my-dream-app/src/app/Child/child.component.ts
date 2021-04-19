import { Component, Input, OnInit, Output,EventEmitter } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.scss']
})
export class ChildComponent implements OnInit {

  @Input("parentText") parentText:string;
  @Output("childData") childData:EventEmitter<string> = new EventEmitter<string>();
  childdata:string;
  constructor() { }

  ngOnInit(): void {
  }

  sendDataToParent(value:string){
    this.childData.emit(value);
  }
}
