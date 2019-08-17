using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Employee
{
    // build an employee Node
    public class Node
    {
        public string employeeId = null;
        public string managerId = null;
        public int employeeSalary;
        public Node next = null;

        public Node(string employeeId, string managerId, int employeeSalary)
        {
            this.employeeId = employeeId;
            this.managerId = managerId;
            this.employeeSalary = employeeSalary;
        }
    }
}
