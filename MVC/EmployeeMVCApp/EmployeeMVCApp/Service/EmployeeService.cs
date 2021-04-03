using EmployeeMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeMVCApp.Service
{
    public class EmployeeService
    {
        private static EmployeeService _employeeService;
        private List<Employee> _employees = new List<Employee>();

        public static EmployeeService GetInstance {

            get {
                if (_employeeService == null) {
                    _employeeService = new EmployeeService();
                }
                return _employeeService;
            }
        }
        public EmployeeService() 
        {
            _employees.Add(new Employee() { ID = 101, Name = "Sumit Gupta", Designation = "Manager", Salary = "2000" });
            _employees.Add(new Employee() { ID = 102, Name = "Yogesh Patel", Designation = "HR", Salary = "5000" });
            _employees.Add(new Employee() { ID = 103, Name = "Ramesh Rathod", Designation = "CEO", Salary = "8000" });
            _employees.Add(new Employee() { ID = 104, Name = "Mika Singh", Designation = "Manger", Salary = "2500" });
        }
        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public void AddEmployee(Employee employee) 
        {
            _employees.Add(employee);
        }

        public void EditEmployee(Employee employee) 
        {
            Employee emp = _employees.Where(x => x.ID == employee.ID).SingleOrDefault();
            emp.Name = employee.Name;
            emp.Salary = employee.Salary;
            emp.Designation = employee.Designation;
        }
    }
}