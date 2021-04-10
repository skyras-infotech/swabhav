﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjectWebAPIDemoApp.Models;

namespace NinjectWebAPIDemoApp.Service
{
    public class EmployeeService : IEmployeeService
    {
        //private static EmployeeService _empService;
        private List<Employee> employees = new List<Employee>();

       /* public static EmployeeService GetInstance
        {
            get
            {
                if (_empService == null)
                {
                    _empService = new EmployeeService();
                }
                return _empService;
            }
        }*/

        public EmployeeService()
        {
            employees.Add(new Employee() { ID = 101, EmployeeName = "Sumit Gupta", Department = "Manager", Salary = 10000 });
            employees.Add(new Employee() { ID = 102, EmployeeName = "Yogesh Patel", Department = "CEO", Salary = 20000 });
            employees.Add(new Employee() { ID = 103, EmployeeName = "Ajay Patil", Department = "IT", Salary = 25000 });
            employees.Add(new Employee() { ID = 104, EmployeeName = "Karan Patel", Department = "CEO", Salary = 30000 });
            employees.Add(new Employee() { ID = 105, EmployeeName = "Niyati Gupta", Department = "Expense", Salary = 15000 });
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee GetEmployeeByID(int id)
        {
            return employees.Where(x => x.ID == id).SingleOrDefault();
        }

       /* public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }*/
    }
}