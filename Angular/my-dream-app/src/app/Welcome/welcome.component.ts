import { Component } from '@angular/core';

@Component({
  selector: 'sw-welcome',
  templateUrl: './welcome.component.html',
})
export class WelcomeComponent {
  developerName: string
  constructor() {
    this.developerName = "Sumit Gupta";
  }
  title = 'my-dream-app';
}
