using System;
using System.Collections.Generic;
using EmployeeManagement.BL;
using System.Linq;

namespace EmployeeManagement.DAL
{
    public class MockEmployeeRepository: IEmployeeRepositoryInterface
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id= 1, FirstName="John", LastName="Cena", Designation="Associate", Email="John.cena@hotmai.com", Phone=1234},
                new Employee() { Id= 2, FirstName="Mark", LastName="Pot", Designation=" Sr. Associate", Email="Mark.Pot@hotmai.com", Phone=5677},
                new Employee() { Id= 3, FirstName="Stacy", LastName="Kiebler", Designation="Analyst", Email="Stacy.Kiebler@hotmai.com", Phone=7848},
                new Employee() { Id= 4, FirstName="Kiesl", LastName="Chang", Designation="Associate", Email="Kiesl.chang@hotmai.com", Phone=3223}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(emp => emp.Id) + 1;
            _employeeList.Add(employee);

            return employee;
        }

        public Employee Delete(int id)
        {
            Employee emp = _employeeList.FirstOrDefault(e => e.Id == id);
            if(emp != null)
            {
                _employeeList.Remove(emp);
            }
            return emp;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployeeByID(int employeeId)
        {
            return _employeeList.FirstOrDefault(emp => emp.Id == employeeId);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(emp => emp.Id == employeeChanges.Id);
            if(employee != null)
            {
                employee.FirstName = employeeChanges.FirstName;
                employee.LastName = employeeChanges.LastName;
                employee.Phone = employeeChanges.Phone;
                employee.Designation = employee.Designation;
                employee.Email = employee.Email;
            }
            return employee;
        }
    }
}
