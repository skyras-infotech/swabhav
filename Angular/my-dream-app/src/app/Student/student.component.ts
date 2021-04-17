import { Component } from '@angular/core';
import { IStudent } from "./IStudent";

@Component({
  selector: 'student-app',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent {
  studentList: IStudent[] = [];
  clearList() {
    this.studentList = [];
  }
  loadStudent() {
    this.clearList();
    this.studentList.push({ name: "Sumit Gupta", cgpa: 9.7, image: "https://images.unsplash.com/flagged/photo-1570612861542-284f4c12e75f?ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8cGVyc29ufGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60" });
  }
  loadStudents() {
    this.clearList();
    this.studentList.push({ name: "Sumit Gupta", cgpa: 9.7, image: "https://images.unsplash.com/flagged/photo-1570612861542-284f4c12e75f?ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8cGVyc29ufGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60" });
    this.studentList.push({ name: "Yogesh Patel", cgpa: 9.5, image: "https://images.unsplash.com/photo-1500048993953-d23a436266cf?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTN8fHBlcnNvbnxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60" });
    this.studentList.push({ name: "Sumit Gupta", cgpa: 9.6, image: "https://images.unsplash.com/photo-1577202214328-c04b77cefb5d?ixid=MnwxMjA3fDB8MHxzZWFyY2h8NTl8fHBlcnNvbnxlbnwwfHwwfHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60" });
  }
  title = 'my-dream-app';
}
