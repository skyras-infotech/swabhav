import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  messge: string
  constructor() {
    this.messge = "Hello World";
  }
  title = 'my-dream-app';
}
