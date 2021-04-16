import { Component } from '@angular/core';

@Component({
  selector: 'event-app',
  templateUrl: './event.component.html',
})
export class EventComponent {
    name:string = "";
    fetchData(){
       this.name = ((document.getElementById("display") as HTMLInputElement).value);
    }
    title = 'Event List';
}
