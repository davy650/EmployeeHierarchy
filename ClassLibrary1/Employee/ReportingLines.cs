using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Employee
{
    // this class establishes connections between employee nodes 
    // as reporting lines
    public class ReportingLines
    {
        
        // ceoItem is our head Null at the begining of the list
        // A CEO is the only employee without a manager
        // this algorithm is however o(n) and requires a rewrite to optimize further
        public Node FindCeo(List<Employee> employees)
        {
            Node ceoItem = null;
            foreach (Employee employee in employees)
            {
                if (employee.managerId == "" || employee.managerId == null)
                {
                    ceoItem = new Node(employee.employeeId, null, employee.employeeSalary);
                }
            }

            return ceoItem;
            
        }

        // o(n) - This Algorithm needs more optimization 
        public int BudgetPerManager(List<Employee> employees, string managerId)
        {
            int totalBudget = 0;
            Node currentEmployee = null;
            int startCompute = 0;

            foreach (Employee employee in employees)
            {
                try
                {
                    currentEmployee =  new Node(employee.employeeId, employee.managerId, employee.employeeSalary);
                    if (currentEmployee.employeeId == managerId) startCompute = 1;

                    if (startCompute > 0) totalBudget += currentEmployee.employeeSalary;

                    currentEmployee = currentEmployee.next;
                }
                catch
                {

                }
            }

            return totalBudget;
        }

    }
}
