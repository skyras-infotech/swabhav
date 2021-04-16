import { Component } from '@angular/core';
import { IEmployee } from "./IEmployee";

@Component({
  selector: 'emp-app',
  templateUrl: './employee.component.html',
})
export class EmployeeComponent {

  name: string = "";
  mobile: string = "";
  salary: string = "";
  EmployeeList: IEmployee[] = [];
  loadEmployee() {
    this.EmployeeList.push({ name: this.name, mobile: this.mobile, salary: this.salary });
    this.name = "";
    this.mobile = "";
    this.salary = "";
  }
  title = 'Employee List';
}
