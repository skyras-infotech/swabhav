import { Component } from '@angular/core';
import { IStudent } from "./IStudent";

@Component({
  selector: 'student-app',
  templateUrl: './student.component.html',
})
export class StudentComponent {
    studentList:IStudent[] = [];
    loadStudent(){
        this.studentList.push({name:"Sumit Gupta",mobile:7600965621,address:"Navsari"});
        this.studentList.push({name:"Yogesh Patel",mobile:9874563215,address:"Valsad"});
        this.studentList.push({name:"Sumit Gupta",mobile:9632587415,address:"Method"});
    }
    title = 'my-dream-app';
}
