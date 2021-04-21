import { Component, OnInit } from '@angular/core';
import { StudentService } from './student.service';
import { IStudent } from './IStudent';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  students:IStudent[];

  constructor(private _studentService:StudentService) { }

  ngOnInit(): void {
    this._studentService.getContacts().subscribe(data => this.students = data);
  }

}
