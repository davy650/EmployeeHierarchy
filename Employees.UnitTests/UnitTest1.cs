using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Employees.UnitTests
{
    [TestClass]
    public class EmployeeHierarchyTests
    {
        [TestMethod]
        public void CalculateBudgetPerManager_ManagerIdProvided_ReturnsInt()
        {
            // Arrange 
            var employeeHirachy = new EmployeeHierarchy();
            string csvPath = "C:\\Uploads\\Employee-Hirachy.csv";
            string managerID = "10001";
            int compare = 1;

            // Act 
            var result = employeeHirachy.CalculateBudgetPerManager(csvPath, managerID);

            // Assert
            Assert.AreEqual(result.GetType(), compare.GetType());
        }


        [TestMethod]
        public void CalculateBudgetPerManager_ManagerIdProvided_ReturnsCorrectTotalBudget()
        {
            var employeeHirachy = new EmployeeHierarchy();
            string csvPath = "C:\\Uploads\\Employee-Hirachy.csv";
            string managerID = "10002";
            int expectedResult = 15000;

            // Act 
            var result = employeeHirachy.CalculateBudgetPerManager(csvPath, managerID);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
