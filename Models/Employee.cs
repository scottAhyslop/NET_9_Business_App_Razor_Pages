﻿using NET_9_Business_App_Razor_Pages.Models;
using NET_9_Business_App_Razor_Pages.Pages.Employees;
using System.ComponentModel.DataAnnotations;

namespace NET_9_Business_App_RazorPages.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeePosition { get; set; }
        public string EmployeeDepartment { get; set; }
        public double EmployeeSalary { get; set; }

        public Employee(int employeeId, string employeeFirstName, string employeeLastName, string employeePosition, string employeeDepartment, double employeeSalary)
        {
            EmployeeId = employeeId;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            EmployeePosition = employeePosition;
            EmployeeDepartment = employeeDepartment;
            EmployeeSalary = employeeSalary;
        }
    }//end Employee class
}
