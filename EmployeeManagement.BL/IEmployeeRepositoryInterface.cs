using System;
using System.Collections.Generic;

namespace EmployeeManagement.BL
{
    public interface IEmployeeRepositoryInterface
    {

        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeByID(int employeeId);
        Employee Add(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee Delete(int id);
        
    }
}
