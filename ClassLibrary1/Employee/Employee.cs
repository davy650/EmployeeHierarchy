using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Employee
{
    // build an employee model
    public class Employee
    {
        public string employeeId { get; set; }
        public string managerId { get; set; }
        public int employeeSalary { get; set; }

        public Employee(string employeeId, string managerId, int employeeSalary)
        {
            this.employeeId = employeeId;
            this.managerId = managerId;
            this.employeeSalary = employeeSalary;
        }
    }
}
