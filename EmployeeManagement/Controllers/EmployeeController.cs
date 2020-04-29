using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.BL;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepositoryInterface employeeRepository;

        public EmployeeController(IEmployeeRepositoryInterface employeeRepository)
        {
            if (employeeRepository == null)
                throw new ArgumentNullException("employee Repository");

            this.employeeRepository = employeeRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var employees = employeeRepository.GetAllEmployees();
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            Employee employee = employeeRepository.GetEmployeeByID(id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult CreateEmployee(int id = 0)
        {
            return View("Create", new Employee());
        }

        [HttpPost]
        public RedirectToActionResult CreateEmployee(Employee employee)
        {
            if(ModelState.IsValid)
            {
                Employee empl = employeeRepository.Add(employee);
                return RedirectToAction("Details", new {id= empl.Id });
            }
            return RedirectToAction("Create", employee);
        }


    }
}
