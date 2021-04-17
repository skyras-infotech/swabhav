import { Component, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'app-loginTemplate',
  templateUrl: './loginTemplate.component.html'
})
export class LoginTemplateComponent {

  username:string;
  password:string;
  @ViewChild('f') form: any;
  constructor() {
  }

  login(){
    if (this.form.valid) {
      console.log("Form Submitted!");
      this.form.reset();
    }
  }
}
