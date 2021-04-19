import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipe',
  templateUrl: './pipe.component.html',
  styleUrls: ['./pipe.component.scss']
})
export class PipeComponent implements OnInit {

  name:string = "My Name is Sumit Gupta";
  constructor() { }

  ngOnInit(): void {
  }

}
