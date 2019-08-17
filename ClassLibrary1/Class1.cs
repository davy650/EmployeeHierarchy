using System;
using System.Collections.Generic;
using System.IO;

namespace ClassLibrary1
{
    public class EmployeeHierarchy
    {
        // calculate budget per manager
        public int CalculateBudgetPerManager(string csvPath, string managerId)
        {
            Employee.ReportingLines reportingLines = new Employee.ReportingLines();
            return reportingLines.BudgetPerManager(UploadCSV(csvPath), managerId);
        }

        // upload csv
        public List<Employee.Employee> UploadCSV(string csvPath)
        {

            List<Employee.Employee> employeesList = new List<Employee.Employee>();
            using (var reader = new StreamReader(@csvPath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    var employee = new Employee.Employee(values[0], values[1], int.Parse(values[2]));
                    employeesList.Add(employee);
                }
            }

            return employeesList;
        }

        
    }


}
