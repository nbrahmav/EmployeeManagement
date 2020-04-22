using System;
using System.Collections.Generic;
using EmployeeManagement.BL;

namespace EmployeeManagement.DAL
{
    public class EmployeeRepository: IEmployeeRepositoryInterface
    {
        public EmployeeRepository()
        {
        }

        public Employee Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeByID(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Employee Update(Employee employeeChanges)
        {
            throw new NotImplementedException();
        }
    }
}
