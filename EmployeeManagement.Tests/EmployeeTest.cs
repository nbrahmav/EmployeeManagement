using System;
using System.Collections.Generic;
using NUnit.Framework;
using EmployeeManagement.BL;
using EmployeeManagement.DAL;

namespace EmployeeManagement.Tests
{
    [TestFixture]
    public class EmployeeTest
    {

        [Test]
        public void AddEmployeetoList_ShouldWork()
        {
            //Arrange
            Employee employee = new Employee() { FirstName = "John", LastName = "Mark", Designation= "Analyst" };
            

            //Act
            MockEmployeeRepository mockEmployeeRepository = new MockEmployeeRepository();
            mockEmployeeRepository.Add(employee);

            //Assert
            Assert.True(employee.Id > 4);

            //Assert.Contains(employee,employeelist);


        }
    }
}
